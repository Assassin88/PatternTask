using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class Process
    {
        protected abstract void Enter();
        protected abstract void Study();
        protected abstract void PassExam();
        protected abstract void GetAttestat();

        public void EnterProcess()
        {
            Enter();
            Study();
            PassExam();
            GetAttestat();
        }
    }
}
