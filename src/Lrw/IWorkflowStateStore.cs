﻿namespace Lrw
{
    public interface IWorkflowStateStore
    {
        WorkflowState Get(string key);
        void Store(string key, WorkflowState state);
    }
}
