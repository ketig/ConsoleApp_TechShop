namespace ConsoleAppSecondYear_TechShop
{
    class Phone
    {
        private string _brand;
        private string _price;
        private string _model;
        private uint _RAM; // unsigned int - უნიშნო
        private uint _memory;
        private uint _quantity;

        public string GetBrand()
        {
            return _brand;
        }

        public string GetPrice()
        {
            return _price;
        }

        public void SetPrice(string value)
        {
            _price = value;
        }

        public uint GetQuantity()
        {
            return _quantity;
        }

        public Phone(
            string brand, string price,
            string model, uint RAM,
            uint memory, uint quantity)
        {
            _brand = brand;
            _price = price;
            _model = model;
            _RAM = RAM;
            _memory = memory;
            _quantity = quantity;
        }
    }
}
