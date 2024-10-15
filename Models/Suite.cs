namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string roomType, int capacity, decimal dailyValue)
        {
            RoomType = roomType;
            Capacity = capacity;
            DailyValue = dailyValue;
        }

        private String _roomtype;
        public String RoomType
        {
            get { return _roomtype; }
            set { _roomtype = value; }
        }
        private int _capacity;
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        
        private Decimal _dailyvalue;
        public Decimal DailyValue
        {
            get { return _dailyvalue; }
            set { _dailyvalue = value; }
        }
    }
}