using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISO._20022.Messages.ACMT.ACMT.Messages.V01
{
    public class Acmt
    {
        public partial class MessageIdentification1
        {

            private string idField;

            private DateTime creDtTmField;

            /// <remarks/>
            public string Id
            {
                get
                {
                    return idField;
                }
                set
                {
                    idField = value;
                }
            }

            /// <remarks/>
            public DateTime CreDtTm
            {
                get
                {
                    return creDtTmField;
                }
                set
                {
                    creDtTmField = value;
                }
            }
        }

        public partial class InvestmentFundOrder4
        {

            private string ordrRefField;

            private string mstrRefField;

            /// <remarks/>
            public string OrdrRef
            {
                get
                {
                    return ordrRefField;
                }
                set
                {
                    ordrRefField = value;
                }
            }

            /// <remarks/>
            public string MstrRef
            {
                get
                {
                    return mstrRefField;
                }
                set
                {
                    mstrRefField = value;
                }
            }
        }
    }
}
