using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using MMBSoftware.Models.Enums;

namespace MMBSoftware.Models
{
    public class Stock
    {
        private int _id;
        private int _productId;
        private string _name;
        private string _category;
        private int _quantity;
        private UnitType _unitType;
        private DateTime _entryDate;
        private DateTime _expiryDate;

        private string _unitTypeDisplay;

        
        [DisplayName("Nome do Produto")]
        public string Product_Name
        {
            get { return _name; }
            set { _name = value; }
        }


        [DisplayName("Quantidade")]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade deve ser um número positivo.")]
        [Required(ErrorMessage = "É necessário informar a quantidade em estoque!")]
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "É necessário informar o tipo de unidade!")]
        [Browsable(false)]
        public UnitType Unit_Type
        {
            get { return _unitType; }
            set { _unitType = value; }
        }


        [DisplayName("Tipo de Unidade")]
        [DataType(DataType.Text)]
        public string Unit_TypeDisplay
        {
            get { return _unitTypeDisplay; }
            set { _unitTypeDisplay = value; }
        }

        [DisplayName("Categoria do Produto")]
        [Browsable(false)]
        public string Product_Category
        {
            get { return _category; }
            set { _category = value; }
        }

        [DisplayName("Data de Entrada")]
        [Required(ErrorMessage = "A data de entrada é necessária!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Entry_Date
        {
            get { return _entryDate; }
            set { _entryDate = value; }
        }

        [DisplayName("Data de Validade")]
        [Required(ErrorMessage = "A data de validade é necessária!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Expiry_Date
        {
            get { return _expiryDate; }
            set { _expiryDate = value; }
        }

        [DisplayName("Código do Estoque")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DisplayName("Código do Produto")]
        [Required(ErrorMessage = "É necessário informar o ID do produto!")]
        [Range(1, 100000, ErrorMessage = "Selecione um produto válido!")]
        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }
    }
}
