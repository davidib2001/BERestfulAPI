using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulDomain
{

        public enum TASKSTATUS
        {
            /// <summary>
            /// None - Task is unknown
            /// </summary>
            None = 0,
            /// <summary>
            /// Complete - Task is completed
            /// </summary>
            Complete = 1,
            /// <summary>
            /// InQueue - task is in waiting queue to execute
            /// </summary>
            InQueue = 2,
            /// <summary>
            /// Executing - task is processing by calculation engines
            /// </summary>
            Executing = 3,
            /// <summary>
            /// CompleteWithError - task is completed with execution errors
            /// </summary>
            CompleteWithError = 4,
            //Task canceled by user.
            Canceled = 5
        }

        public enum ERRORCODES
        {
            None = 0,
            UnAuthorized = 1,
            Error = 2
        }

        //<note> BondEdge Legacy
        public enum SecurityErrorCodes
        {
            None = 0,
            InvalidCallSchedule = 1,   //invalid call schedule.
            InvalidPutSchedule = 2,     //invalid put schedule.
            InvalidSinkSchedule = 3,    //invalid sink schedule.
            InvalidCouponSchedule = 4,  // invalid coupon schedule.
            InvalidmaturityDate = 5,    //maturity date < settle date.
            ExtendedFileError = 6,      //can not find or write extended temporary file.
            CalculationSuccess = 7,     //calculation success
            CalculationFail = 8,        //Calculation failed
            InvalidBallonType = 9,      //invalid baloon payment type.
            InvalidPoolIssueType = 10,   // can not process MIX type.
            InvaliWam = 11,              //invalid wam to maturity months
            InvalidMaturityMonths = 12   // marutity months greater than ballon months.
        }

}
