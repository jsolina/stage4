﻿using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;

namespace Domain.Contracts
{
    public interface ITaskListRepo : IBaseRepo<TaskListModel>
    {
        void aw();
    }
}
