﻿using DesignPatternChainOfResponsibility.Models;

namespace DesignPatternChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover; 
        public void SetNextApprover (Employee employee)
        { 
            this.NextApprover = employee;
        }
        public abstract void ProcessRequest(CustomerProcessViewModel req);
    }
}
