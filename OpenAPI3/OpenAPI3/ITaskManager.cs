using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;


namespace OpenAPI3
{
    public interface ITaskManager
    {
        ITaskStatus requestSecurityOASAnalysis(SecurityOASAnalysisRequest srp);
        SecurityOASAnalysisResponseRestful respondSecurityOASAnalysis();
        ITaskStatus requestSecurityAnalyticalOutput(SecurityAnalyticalMeasureRequest srp);
        SecurityAnalyticalMeasureResponseRestful respondSecurityAnalyticalOutput();
        ITaskStatus requestSecurityStaticCashFlow(SecurityCashFlowRequest srp);
        SecurityCashFlowResponseRestful respondSecurityStaticCashFlow();
#if false
        Domain.ITaskStatus requestSecurityAnalysis(SecurityRequest srp);
        SecurityResponse respondSecurityAnalysis();

        Domain.ITaskStatus requestSecurityAnalysis(object srp);
        object respondSecurityAnalysis();
        Domain.ITaskStatus requestSecurityOASAnalysis(object srp);
        object respondSecurityOASAnalysis();
        Domain.ITaskStatus requestSecurityParallelSimulation(object srp);
        object respondSecurityParallelSimulation();
        Domain.ITaskStatus requestSecuritySpecifiedScenario(object srp);
        object respondSecuritySpecifiedScenario();
        Domain.ITaskStatus requestBondSwap(object srp);
        object respondBondSwap();
        Domain.ITaskStatus requestUser(object srp);
        object respondUser();
#endif


    }
}
