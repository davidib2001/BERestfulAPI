using System.Collections.Generic;
using System.Linq;
//using InteractiveDataFIA.BondEdge;
using System;
using System.Timers;
using System.Threading;
using System.Collections.Concurrent;
using Domain;
using RestfulDomain;
using Bondedge;
using InteractiveDataFIA.BondEdge;


namespace OpenAPI3
{
public class TaskManager : ITaskManager
{
    SecurityAnalyticalMeasureResponse emReplyMessage;
    Bondedge.API enterpriseMessageBusInterface2;
    private String emReplyMessageLock = "";

    public ITaskStatus requestSecurity(SecurityRequest srp)
    {
        emReplyMessage = null;
        //access to the message bus, of course parms grabbed from .config or data store
        enterpriseMessageBusInterface2 = new Bondedge.API("bondedge1", "openapi", "password");
        enterpriseMessageBusInterface2.RegisterClient("Kirk"/*srp.GetUser()*/, Callback);
        

        //tranlsate client message to message bus message
        //Domain.IRequest domainRequestMessage = OpenAPIToServiceBus.MessageTranslators.IWebAPISecurityInfoToEnterpriseMessage(tasks.ToWebApiSecurityInfoList()[0]);
        Domain.IRequest domainRequestMessage = OpenAPIToServiceBus.MessageTranslators.simpleToEnterpriseMessage(srp.Securities[0].Identifier, (int)srp.Securities[0].AsOfDate, 1.0);
        //<todo> move these into the message translator and setting igor is obviously a no no 
        //<todo> add this into the message translator, here right now for testing <20140904>
        domainRequestMessage.SetUser("Kirk"/*srp.GetUser()*/);
        domainRequestMessage.SetID(srp.ID != Guid.Empty ? srp.ID : Guid.NewGuid());


        //place the message on the bus, this message gets picked up by the process controller (who provides authorization services)
        //note the callback to capture the results off the bus per this request are handled in here as well
        enterpriseMessageBusInterface2.SendRequest(domainRequestMessage);


        //<test> pass back success right now
        return new TaskStatus { Status = TASKSTATUS.Complete, Id = 1, ErrorCode = ERRORCODES.None, Message = "" };

        //<test>
        //embAccessPoint.testConnect(null);
    }


    private void Callback(Domain.IResponse response)
    {
        //<test> 
        lock (emReplyMessageLock)
        {
            emReplyMessage = response as SecurityAnalyticalMeasureResponse;
        }
        int tt = 999;
    }


    public SecurityResponse respondSecurity()
    {
        SecurityResponse result = null;

        SecurityMeasure tmp = null;

        //allow 5 seconds to wait for the responsce
        int dcnt = 70;
        while (dcnt > 0)
        {
            //see if we have a nessage yet
            lock (emReplyMessageLock)
            {
                if (emReplyMessage != null)
                {
                    //have a response but nothing returned
                    if (emReplyMessage.CalulateSecurities == null)
                    {
                        result = new SecurityResponse();
                        result.ErrorCode = ERRORCODES.None;
                        result.Status = TASKSTATUS.Complete;
                        tmp = new SecurityMeasure() { SecurityDescription = "NA" };
                        result.Data = new List<SecurityMeasure>();
                        result.Data.Add(tmp);
                    }

                    //else we have something
                    else
                    {
                        result = new SecurityResponse();
                        
                        result.ErrorCode = ERRORCODES.None;
                        result.Status = TASKSTATUS.Complete;
                        OpenAPIToServiceBus.MessageTranslators.messageBusToSecurityResponse(result, emReplyMessage);
                    }
                    return result;
                }

            }

            //else sleep a bit and try agaon
            Thread.Sleep(100);
            dcnt--;
        }


        result = new SecurityResponse();
        result.ErrorCode = ERRORCODES.Error;
        result.Status = TASKSTATUS.CompleteWithError;
        tmp = new SecurityMeasure() { SecurityDescription = "NA" };
        result.Data = new List<SecurityMeasure>();
        result.Data.Add(tmp);
        return result;
    }
}
}