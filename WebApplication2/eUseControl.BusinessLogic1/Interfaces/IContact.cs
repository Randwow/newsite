using eUseControl.Domain.Entities.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic1.Interfaces
{
    public interface IContact
    {
        bool SendEmail(EmailContact econact);
    }
}
