namespace DesafioProjetoHospedagem.Models
{
    public class Reservation
    {
        private List<Person> _hotelGuest;
        public List<Person> HotelGuest
        {
            get { return _hotelGuest; }
            set { _hotelGuest = value; }
        }
        private Suite _hotelRoomSuite;
        public Suite HotelRoomSuite
        {
            get { return _hotelRoomSuite; }
            set { _hotelRoomSuite = value; }
        }
        private int _reservationDays;
        public int ReservationDays
        {
            get { return _reservationDays; }
            set { _reservationDays = value; }
        }

        public Reservation() { }

        public Reservation(int reservationDays)
        {
            ReservationDays = reservationDays;
        }

        public void RegisterGuests(List<Person> guests)
        {
            if (HotelRoomSuite.Capacity == guests.Count)
            {
                HotelGuest = guests;
            }
            else
            {
                throw new Exception("The number of Guests is greater than Suite Capacity");
            }
        }

        public void RegisterSuite(Suite suite)
        {
            HotelRoomSuite = suite;
        }

        public int GetGuestCount()
        {
            return HotelGuest.Count;
        }

        public decimal CalculateDailyValue()
        {
            decimal value = HotelRoomSuite.DailyValue * ReservationDays;
            if (ReservationDays >= 10)
            {
                value -= value * 1/10M;
            }
            return value;
        }
    }
}