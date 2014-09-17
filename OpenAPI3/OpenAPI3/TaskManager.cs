using System.Collections.Generic;
using System.Linq;
//using InteractiveDataFIA.BondEdge;
using System;
using System.Timers;
using System.Threading;
using System.Collections.Concurrent;
using Domain;
using Bondedge;
using InteractiveDataFIA.BondEdge;


namespace OpenAPI3
{
public class TaskManager : ITaskManager
{
    SecurityAnalyticalMeasureResponse emReplyMessage;
    Bondedge.API enterpriseMessageBusInterface2;

    //<todo> obviously from app/web .config
    private IResponse responseMsg;
    private Object responseMsgLock = null;
    private string msgBus = "";
    private string rabbitUser = "";
    private string rabbitPwd = "";
    private int waitForResponseHalfSeconds = 10;


    #region SECURITY ANALYTICAL
    public ITaskStatus requestSecurityAnalyticalOutput(SecurityAnalyticalMeasureRequest srp)
    {
        responseMsg = null;
        enterpriseMessageBusInterface2 = new Bondedge.API(msgBus, rabbitUser, rabbitPwd);
        enterpriseMessageBusInterface2.RegisterClient(srp.GetUser(), Callback);


        //tranlsate client message to message bus message
        srp.SetID(srp.ID != Guid.Empty ? srp.ID : Guid.NewGuid());

        //place the message on the bus
        enterpriseMessageBusInterface2.SendRequest(srp);


        //<test> pass back success right now
        return new TaskStatus { Status = Enums.TASKSTATUSCODE.Complete, systemReturnCode = Enums.ERRORCODES.None, Message = "" };
    }



    public SecurityAnalyticalMeasureResponseRestful respondSecurityAnalyticalOutput()
    {
        SecurityAnalyticalMeasureResponseRestful r = null;

        //wait x sec for response
        int dcnt = waitForResponseHalfSeconds;
        while (dcnt > 0)
        {
            lock (responseMsgLock)
            {
                if (responseMsg != null && responseMsg is SecurityOASAnalysisResponse)
                {
                    r = new SecurityAnalyticalMeasureResponseRestful(responseMsg as SecurityAnalyticalMeasureResponse);
                    if (r.CalulateSecurities[0].Identifier == null)
                    {
                        r.Status = Enums.TASKSTATUSCODE.CompleteWithError;
                        r.systemReturnCode = Enums.ERRORCODES.Error;
                        r.Message = "";
                    }

                    //else we have something
                    else
                    {
                        r.systemReturnCode = Enums.ERRORCODES.None;
                        r.Status = Enums.TASKSTATUSCODE.Complete;
                        r.Message = "";
                    }
                    return r;
                }

            }
            Thread.Sleep(500);
            dcnt--;
        }

        //else no response back
        r = new SecurityAnalyticalMeasureResponseRestful();
        r.Status = Enums.TASKSTATUSCODE.Canceled;
        r.systemReturnCode = Enums.ERRORCODES.None;
        r.Message = "";
        return r;
    }

    #endregion

    #region SECURITY OAS ANALYSIS
    public ITaskStatus requestSecurityOASAnalysis(SecurityOASAnalysisRequest srp)
    {
        responseMsg = null;
        enterpriseMessageBusInterface2 = new Bondedge.API(msgBus, rabbitUser, rabbitPwd);
        enterpriseMessageBusInterface2.RegisterClient(srp.GetUser(), Callback);


        //tranlsate client message to message bus message
        srp.SetID(srp.ID != Guid.Empty ? srp.ID : Guid.NewGuid());

        //place the message on the bus
        enterpriseMessageBusInterface2.SendRequest(srp);


        //<test> pass back success right now
        return new TaskStatus { Status = Enums.TASKSTATUSCODE.Complete,  systemReturnCode = Enums.ERRORCODES.None, Message = "" };
    }

   

    public SecurityOASAnalysisResponseRestful respondSecurityOASAnalysis()
    {
        SecurityOASAnalysisResponseRestful r = null;

        //wait x sec for response
        int dcnt = waitForResponseHalfSeconds;
        while (dcnt > 0)
        {
            lock (responseMsgLock)
            {
                if (responseMsg != null && responseMsg is SecurityOASAnalysisResponse)
                {
                    r = new SecurityOASAnalysisResponseRestful(responseMsg as SecurityOASAnalysisResponse);
                    if (r.CalculateSecurityOASAnalysis == null)
                    {
                        r.Status = Enums.TASKSTATUSCODE.CompleteWithError;
                        r.systemReturnCode = Enums.ERRORCODES.Error;
                        r.Message = "";
                    }

                    //else we have something
                    else
                    {
                        r.systemReturnCode = Enums.ERRORCODES.None;
                        r.Status = Enums.TASKSTATUSCODE.Complete;
                        r.Message = "";
                    }
                    return r;
                }

            }
            Thread.Sleep(500);
            dcnt--;
        }

        //else no response back
        r = new SecurityOASAnalysisResponseRestful();
        r.Status = Enums.TASKSTATUSCODE.Canceled;
        r.systemReturnCode = Enums.ERRORCODES.None;
        r.Message = "";
        return r;
    }
    #endregion

    #region SECURITY STATIC CASH FLOW
    public ITaskStatus requestSecurityStaticCashFlow(SecurityCashFlowRequest srp)
    {
        responseMsg = null;
        enterpriseMessageBusInterface2 = new Bondedge.API(msgBus, rabbitUser, rabbitPwd);
        enterpriseMessageBusInterface2.RegisterClient(srp.GetUser(), Callback);


        //tranlsate client message to message bus message
        srp.SetID(srp.ID != Guid.Empty ? srp.ID : Guid.NewGuid());

        //place the message on the bus
        enterpriseMessageBusInterface2.SendRequest(srp);


        //<test> pass back success right now
        return new TaskStatus { Status = Enums.TASKSTATUSCODE.Complete, systemReturnCode = Enums.ERRORCODES.None, Message = "" };
    }



    public SecurityCashFlowResponseRestful respondSecurityStaticCashFlow()
    {
        SecurityCashFlowResponseRestful r = null;

        //wait x sec for response
        int dcnt = waitForResponseHalfSeconds;
        while (dcnt > 0)
        {
            lock (responseMsgLock)
            {
                if (responseMsg != null && responseMsg is SecurityCashFlowResponse)
                {
                    r = new SecurityCashFlowResponseRestful(responseMsg as SecurityCashFlowResponse);
                    if (r.CashFlow == null || r.CashFlow.Identifier == null)
                    {
                        r.Status = Enums.TASKSTATUSCODE.CompleteWithError;
                        r.systemReturnCode = Enums.ERRORCODES.Error;
                        r.Message = "";
                    }

                    //else we have something
                    else
                    {
                        r.systemReturnCode = Enums.ERRORCODES.None;
                        r.Status = Enums.TASKSTATUSCODE.Complete;
                        r.Message = "";
                    }
                    return r;
                }

            }
            Thread.Sleep(500);
            dcnt--;
        }

        //else no response back
        r = new SecurityCashFlowResponseRestful();
        r.Status = Enums.TASKSTATUSCODE.Canceled;
        r.systemReturnCode = Enums.ERRORCODES.None;
        r.Message = "";
        return r;
    }


    #endregion



    private void Callback(IResponse response)
    {
        lock (responseMsg)
        {
            responseMsg = response;
        }
    }

#if false
    #region OLD CODE
    public ITaskStatus requestSecurity(SecurityRequest srp)
    {
        emReplyMessage = null;
        //access to the message bus, of course parms grabbed from .config or data store
        enterpriseMessageBusInterface2 = new Bondedge.API(msgBus,rabbitUser,rabbitPwd);
        enterpriseMessageBusInterface2.RegisterClient(srp.GetUser(), Callback);
        

        //tranlsate client message to message bus message
        Domain.IRequest domainRequestMessage = OpenAPIToServiceBus.MessageTranslators.simpleToEnterpriseMessage(srp.Securities[0].Identifier, (int)srp.Securities[0].AsOfDate, 1.0);
        domainRequestMessage.SetID(srp.ID != Guid.Empty ? srp.ID : Guid.NewGuid());

       //place the message on the bus
        enterpriseMessageBusInterface2.SendRequest(domainRequestMessage);

        //<test> pass back success right now
        return new TaskStatus { Status = TASKSTATUS.Complete, Id = 1, ErrorCode = ERRORCODES.None, Message = "" };

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
    #endregion
#endif
}
}