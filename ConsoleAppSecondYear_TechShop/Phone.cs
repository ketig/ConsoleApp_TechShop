namespace ConsoleAppSecondYear_TechShop
{
    class Phone
    {
        private string _brand;
        private string _price;
        private string _model;
        private uint _RAM;
        private uint _memory;
        private uint _quantity;

        public string Brand
        {
            get
            {
                return _brand;
            }
        }

        public string Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public string Model { get { return _model; } }

        public uint RAM { get { return _RAM; } }
        public uint Memory { get { return _memory; } }

        public uint Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
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

        // Print


        // Sell - gayidva


        // Buy - maragshi damateba


    }
}
