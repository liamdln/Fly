using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fly.Components
{
    class UserCard
    {

        private readonly string _cardNumber;

        public bool IsValid { get; }

        public UserCard(string cardNumber)
        {
            _cardNumber = cardNumber;
        }

        private bool ValidCardNumber()
        {
            Regex rgx = new Regex(@"^[0-9]{16}");
            return rgx.IsMatch(_cardNumber);
        }

    }
}
