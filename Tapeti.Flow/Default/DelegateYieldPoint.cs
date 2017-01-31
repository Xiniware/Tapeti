﻿using System;
using System.Threading.Tasks;

namespace Tapeti.Flow.Default
{
    internal interface IExecutableYieldPoint : IYieldPoint
    {
        bool StoreState { get; }

        Task Execute(FlowContext context);
    }


    internal class DelegateYieldPoint : IYieldPoint
    {
        public bool StoreState { get; }

        private readonly Func<FlowContext, Task> onExecute;


        public DelegateYieldPoint(bool storeState, Func<FlowContext, Task> onExecute)
        {
            StoreState = storeState;
            this.onExecute = onExecute;
        }


        public Task Execute(FlowContext context)
        {
            return onExecute(context);
        }
    }
}