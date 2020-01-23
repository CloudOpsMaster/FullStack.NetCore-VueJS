 public struct Notebook
    {
        public int price;
        public string model;
        public string manufacturer;
        
        
        public Notebook(string value)
        {
            this.price = value;
            this.model = value;
            this.manufacturer = value;
            
        }
 
        public Notebook(string model, string manufacturer,int price)
        {
            this.price = price;
            this.model = model;
            this.manufacturer = manufacturer;
            
            price = 590000;
            model = "PowerEdge T130 ";
            manufacturer = "Вудд";
            
        }
       
    }