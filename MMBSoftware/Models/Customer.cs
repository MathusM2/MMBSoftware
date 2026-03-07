using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MMBSoftware.Models
{
    public class Customer
    {
        private int _id;
        private string _name;
        private string _email;
        private string _phone;
        private string _address;
        private bool _canPlaceOrder;
        private int _accountLimit;
        private string _cpf;
        private IEnumerable<Order> _orders;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DisplayName("Nome do Cliente")]
        [Required(ErrorMessage = "O nome do cliente é necessário!")]
        [StringLength(100, ErrorMessage = "O nome do cliente não pode exceder 100 caracteres")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DisplayName("Email do Cliente")]
        [StringLength(200, ErrorMessage = "O email do cliente não pode exceder 200 caracteres")]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        [DisplayName("Telefone do Cliente")]
        [StringLength(15, ErrorMessage = "O telefone do cliente não pode exceder 15 caracteres")]
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        [DisplayName("Endereço do Cliente")]
        [StringLength(250, ErrorMessage = "O endereço do cliente não pode exceder 250 caracteres")]
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        [DisplayName("Ativo")]
        [Required(ErrorMessage = "O status de atividade do cliente é necessário!")]
        public bool CanPlaceOrder
        {
            get { return _canPlaceOrder; }
            set { _canPlaceOrder = value; }
        }

        public int AccountLimit
        {
            get { return _accountLimit; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("AccountLimit", "O limite da conta não pode ser negativo.");
                }
                _accountLimit = value;
            }
        }

        [DisplayName("CPF")]
        [StringLength(15, ErrorMessage = "O CPF não pode exceder 15 caracteres!")]
        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
    }
}
