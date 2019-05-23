namespace CO599_CP_ABCRenters.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CO599_CP_ABCRenters.Models;
    using System.Collections.Generic;
    using static CO599_CP_ABCRenters.Models.PropertyImage;

    internal sealed class Configuration : DbMigrationsConfiguration<CO599_CP_ABCRenters.Models.PropertyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CO599_CP_ABCRenters.Models.PropertyDbContext";
        }

        protected override void Seed(CO599_CP_ABCRenters.Models.PropertyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            SeedAddress(context);
            SeedCustomer(context);
            SeedProperties(context);
            SeedPropertyImageList(context);



        }

        private void SeedAddress (CO599_CP_ABCRenters.Models.PropertyDbContext context)
        {
            var addressList = new List<Address>
            {
                new Address
                {
                    AddressID = 1,
                    House = "15",
                    StreetName = "High Street",
                    TownName = "Birmingham",
                    Postcode = "BH11 9JR",
                    County = Counties.WARWICKSHIRE

                },

                new Address
                {
                    AddressID = 2,
                    House = "87",
                    StreetName = "Shakespere Road",
                    TownName = "Aylesbury",
                    Postcode = "HP20 1JW",
                    County = Counties.BUCKINGHAMSHIRE

                },

                new Address
                {
                    AddressID = 3,
                    House = "46",
                    StreetName = "Long End Road",
                    TownName = "London",
                    Postcode = "SW41 8QK",
                    County = Counties.LONDON

                },

                new Address
                {
                    AddressID = 4,
                    House = "7",
                    StreetName = "Walton Road",
                    TownName = "Newcastle",
                    Postcode = "NW19 7BA",
                    County = Counties.TYNEANDWEAR

                },

                new Address
                {
                    AddressID = 5,
                    House = "16",
                    StreetName = "Dickens Road",
                    TownName = "Birmingham",
                    Postcode = "BH10 8NA",
                    County = Counties.WARWICKSHIRE

                },

                new Address
                {
                    AddressID = 6,
                    House = "20",
                    StreetName = "Victoria Street",
                    TownName = "London",
                    Postcode = "SW1 7UB",
                    County = Counties.LONDON

                },

                new Address
                {
                    AddressID = 7,
                    House = "25",
                    StreetName = "St. Julians Avenue",
                    TownName = "Aylesbury",
                    Postcode = "HP19 2FL",
                    County = Counties.BUCKINGHAMSHIRE

                }
             };

            addressList.ForEach(s => context.Addresses.AddOrUpdate(p => p.AddressID, s));
            context.SaveChanges();
        }

        private void SeedCustomer(CO599_CP_ABCRenters.Models.PropertyDbContext context)
        {
            var CustomerList = new List<Customer>
            {
                new Customer
                {
                    CustomerID = 1,
                    FirstName = "Thomas",
                    Surname = "Smith",
                    MaritalStatus = MaritalStatusOptions.SINGLE,
                    ContactNumber = "07716836799",
                    EmailAddress = "Thomassmith01@gmail.com",
                    DateOfBirth = new System.DateTime(1999, 10, 10),
                    AddressID = 6
                },

                new Customer
                {
                    CustomerID = 2,
                    FirstName = "John",
                    Surname = "Doe",
                    MaritalStatus = MaritalStatusOptions.MARRIED,
                    ContactNumber = "07717019187",
                    EmailAddress = "Johndoe@hotmail.com",
                    DateOfBirth = new System.DateTime(1989, 01, 12),
                    AddressID = 4
                },

                new Customer
                {
                    CustomerID = 3,
                    FirstName = "Ruby",
                    Surname = "Jones",
                    MaritalStatus = MaritalStatusOptions.SINGLE,
                    ContactNumber = "07761529066",
                    EmailAddress = "Ruby1996@gmail.com",
                    DateOfBirth = new System.DateTime(1996, 07, 04),
                    AddressID = 7
                },

                new Customer
                {
                    CustomerID = 4,
                    FirstName = "Rebecca",
                    Surname = "Morgan",
                    MaritalStatus = MaritalStatusOptions.DIVORCED,
                    ContactNumber = "07902048561",
                    EmailAddress = "BeckyMorgan0101@outlook.com",
                    DateOfBirth = new System.DateTime(1988, 01, 01),
                    AddressID = 5
                }


            };

            CustomerList.ForEach(s => context.Customers.AddOrUpdate(p => p.CustomerID, s));
            context.SaveChanges();
        }

        private void SeedProperties(CO599_CP_ABCRenters.Models.PropertyDbContext context)
        {
            var PropertyList = new List<Property>
            {
                new Property
                {
                    PropertyID = 1,
                    Name = "1 Bedroom studio flat",
                    Description = "In a prime location adjacent to Euston Station is this sleek, furnished, studio apartment on the third floor of the new Churchway development. ",
                    Price = 850,
                    Category = Categories.Flats,
                    AvailableDate = new System.DateTime(2019, 12, 10),
                    EstateAgent = EstateAgents.BROWNMERRY,
                    Bedrooms = 1,
                    AddressID = "3",
                    PetsAllowed = true,
                    IsShared = false
                },

                new Property
                {
                    PropertyID = 2,
                    Name = "3 Bedroom Terraced House",
                    Description = "Williams are pleased to present this 3 bed terraced property for rent. The property comprises of hallway leading to lounge and separate dining room, kitchen with white good included (fridge-freezer, washing machine and cooker), and downstairs bathroom. Upstairs there are 3 spacious bedrooms.",
                    Price = 750,
                    Category = Categories.Terraced,
                    AvailableDate = new System.DateTime(2019, 09, 02),
                    EstateAgent = EstateAgents.WILLIAMS,
                    Bedrooms = 3,
                    AddressID = "1",
                    PetsAllowed = true,
                    IsShared = false
                },

                new Property
                {
                    PropertyID = 3,
                    Name = "2 Bed Semi-Detatched House",
                    Description = "£950 per month | Michael Anthony presents this furnished 2 bedroom house, located walking distance to Westgate Road. ",
                    Price = 950,
                    Category = Categories.SemiDetatched,
                    AvailableDate = new System.DateTime(2020, 02, 10),
                    EstateAgent = EstateAgents.MICHAELANTHONY,
                    Bedrooms = 2,
                    AddressID = "2",
                    PetsAllowed = false,
                    IsShared = false
                }


            };

            PropertyList.ForEach(s => context.Properties.AddOrUpdate(p => p.PropertyID, s));
            context.SaveChanges();

        }

        private void SeedPropertyImageList(CO599_CP_ABCRenters.Models.PropertyDbContext context)
        {
            var PropertyImageList = new List<Models.PropertyImage>
            {
                new Models.PropertyImage
                {
                    PropertyImageID = 1,
                    ImageURL = "/Images/Property 1/Property1.BATHROOM.jpg",
                    Description = "Property 1 Bathroom",
                    Caption = "Bathroom",
                    ImageFormat = ImageFormats.jpg,
                    Rooms = ImageRooms.BATHROOM,
                    PropertyID = 1

                },

                new Models.PropertyImage
                {
                    PropertyImageID = 2,
                    ImageURL = "/Images/Property 1/Property1.BEDROOM.jpg",
                    Description = "Property 1 Bedroom",
                    Caption = "Bedroom",
                    ImageFormat = ImageFormats.jpg,
                    Rooms = ImageRooms.MAIN_BEDROOM,
                    PropertyID = 1

                },

                new Models.PropertyImage
                {
                    PropertyImageID = 3,
                    ImageURL = "/Images/Property 1/Property1.KITCHEN.jpg",
                    Description = "Property 1 Kitchen",
                    Caption = "Kitchen",
                    ImageFormat = ImageFormats.jpg,
                    Rooms = ImageRooms.KITCHEN,
                    PropertyID = 1

                },

                new Models.PropertyImage
                {
                    PropertyImageID = 4,
                    ImageURL = "/Images/Property 1/Property1.LIVINGAREA.jpg",
                    Description = "Property 1 Living Area",
                    Caption = "Living Area",
                    ImageFormat = ImageFormats.jpg,
                    Rooms = ImageRooms.LIVING_AREA,
                    PropertyID = 1

                },

                new Models.PropertyImage
                {
                    PropertyImageID = 5,
                    ImageURL = "/Images/Property 1/Property1.OUTSIDE.jpg",
                    Description = "Property 1 Outside View",
                    Caption = "Outside View",
                    ImageFormat = ImageFormats.jpg,
                    Rooms = ImageRooms.OUTSIDE,
                    PropertyID = 1

                },

                new Models.PropertyImage
                {
                    PropertyImageID = 6,
                    ImageURL = "/Images/Property 2/Property2.BATHROOM.jpg",
                    Description = "Property 2 Bathroom",
                    Caption = "Bathroom",
                    ImageFormat = ImageFormats.jpg,
                    Rooms = ImageRooms.BATHROOM,
                    PropertyID = 2

                },

                new Models.PropertyImage
                {
                    PropertyImageID = 7,
                    ImageURL = "/Images/Property 2/Property2.BEDROOM.jpg",
                    Description = "Property 2 Bedroom",
                    Caption = "Bedroom",
                    ImageFormat = ImageFormats.jpg,
                    Rooms = ImageRooms.MAIN_BEDROOM,
                    PropertyID = 2

                },

                new Models.PropertyImage
                {
                    PropertyImageID = 8,
                    ImageURL = "/Images/Property 2/Property2.GARDEN.jpg",
                    Description = "Property 2 Garden",
                    Caption = "Garden",
                    ImageFormat = ImageFormats.jpg,
                    Rooms = ImageRooms.GARDEN,
                    PropertyID = 2

                },

                new Models.PropertyImage
                {
                    PropertyImageID = 9,
                    ImageURL = "/Images/Property 2/Property2.KITCHEN.jpg",
                    Description = "Property 2 Kitchen",
                    Caption = "Kitchen",
                    ImageFormat = ImageFormats.jpg,
                    Rooms = ImageRooms.KITCHEN,
                    PropertyID = 2

                },

                new Models.PropertyImage
                {
                    PropertyImageID = 10,
                    ImageURL = "/Images/Property 2/Property2.LIVING.jpg",
                    Description = "Property 2 Living Area",
                    Caption = "Living Area",
                    ImageFormat = ImageFormats.jpg,
                    Rooms = ImageRooms.LIVING_AREA,
                    PropertyID = 2

                },

                new Models.PropertyImage
                {
                    PropertyImageID = 11,
                    ImageURL = "/Images/Property 3/Property3.BATHROOM.jpg",
                    Description = "Property 2 Bathroom",
                    Caption = "Bathroom",
                    ImageFormat = ImageFormats.jpg,
                    Rooms = ImageRooms.BATHROOM,
                    PropertyID = 3

                },

                new Models.PropertyImage
                {
                    PropertyImageID = 12,
                    ImageURL = "/Images/Property 3/Property3.GARDEN.jpg",
                    Description = "Property 3 Garden",
                    Caption = "Garden",
                    ImageFormat = ImageFormats.jpg,
                    Rooms = ImageRooms.GARDEN,
                    PropertyID = 3

                },

                new Models.PropertyImage
                {
                    PropertyImageID = 13,
                    ImageURL = "/Images/Property 3/Property3.KITCHEN.jpg",
                    Description = "Property 3 Kitchen",
                    Caption = "Kitchen",
                    ImageFormat = ImageFormats.jpg,
                    Rooms = ImageRooms.KITCHEN,
                    PropertyID = 3

                },

                new Models.PropertyImage
                {
                    PropertyImageID = 14,
                    ImageURL = "/Images/Property 3/Property3.LIVING.jpg",
                    Description = "Property 3 Living Area",
                    Caption = "Living Area",
                    ImageFormat = ImageFormats.jpg,
                    Rooms = ImageRooms.LIVING_AREA,
                    PropertyID = 3

                },

                new Models.PropertyImage
                {
                    PropertyImageID = 15,
                    ImageURL = "/Images/Property 3/Property3.OUTSIDE.jpg",
                    Description = "Property 3 Outside View",
                    Caption = "Outside View",
                    ImageFormat = ImageFormats.jpg,
                    Rooms = ImageRooms.OUTSIDE,
                    PropertyID = 3

                }
            };

            PropertyImageList.ForEach(s => context.PropertyImages.AddOrUpdate(p => p.PropertyImageID, s));
            context.SaveChanges();


        }


            
    }
}
