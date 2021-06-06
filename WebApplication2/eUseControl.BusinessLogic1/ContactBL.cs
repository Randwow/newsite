using eUseControl.BusinessLogic1.Core;
using eUseControl.BusinessLogic1.Interfaces;
using eUseControl.Domain.Entities.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic1
{
    class ContactBL : UserApi, IContact
    {
        public bool SendEmail(EmailContact econact)
        {
            return SendEmailByContact(econact);
        }
    }
}
