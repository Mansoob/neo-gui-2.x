﻿using Neo.Core;
using System.ComponentModel;
using System.Drawing.Design;

namespace Neo.UI.Wrappers
{
    internal class InvocationTransactionWrapper : TransactionWrapper
    {
        [Editor(typeof(HexEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(HexConverter))]
        public byte[] Script { get; set; }
        [TypeConverter(typeof(Fixed8Converter))]
        public Fixed8 Gas { get; set; }

        public override Transaction Unwrap()
        {
            InvocationTransaction tx = (InvocationTransaction)base.Unwrap();
            tx.Script = Script;
            tx.Gas = Gas;
            return tx;
        }
    }
}
