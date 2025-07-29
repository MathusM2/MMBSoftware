using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MMBSoftware.Models
{
    public class Stock
    {
        private int _id;
        private int _productId;
        private string _name;
        private string _category;
        private int _quantity;
        private DateTime _entryDate;

        [DisplayName("Id")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DisplayName("Produto Id")]
        [Required(ErrorMessage = "É necessário informar o ID do produto!")]
        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        [DisplayName("Nome do Produto")]
        public string Product_Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DisplayName("Categoria do Produto")]
        [Browsable(false)]
        public string Product_Category
        {
            get { return _category; }
            set { _category = value; }
        }

        [DisplayName("Quantidade")]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade deve ser um número positivo.")]
        [Required(ErrorMessage = "É necessário informar a quantidade em estoque!")]
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        [DisplayName("Data de Entrada")]
        [Required(ErrorMessage = "A data de entrada é necessária!")]
        public DateTime Entry_Date
        {
            get { return _entryDate; }
            set { _entryDate = value; }
        }
    }
}
