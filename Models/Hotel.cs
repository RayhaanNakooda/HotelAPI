namespace HotelAPI{

 public class Hotel
{

public Hotel(){
    
}

public Hotel(int id, string name , string website, string city, int rating, string imageURL){
    HotelID = id;
    Name = name;
    Website = website;
    City = city;
    Rating = rating;
    ImageURL = imageURL;
}

public int HotelID { get; set; }
public string Name { get; set; }
public string Website { get; set; }
public string City { get; set; }
public int Rating  { get; set; }
public string ImageURL { get; set; }


}

}



