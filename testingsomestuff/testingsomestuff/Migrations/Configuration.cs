namespace testingsomestuff.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<testingsomestuff.OkurLeigaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(testingsomestuff.OkurLeigaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            #region postnumbers

            PostNumber pn1 = new PostNumber()
            {
                PostNumbersss = 109
            };
            PostNumber pn2 = new PostNumber()
            {
                PostNumbersss = 108
            };
            PostNumber pn3 = new PostNumber()
            {
                PostNumbersss = 107
            };
            PostNumber pn4 = new PostNumber()
            {
                PostNumbersss = 106
            };
            PostNumber pn5 = new PostNumber()
            {
                PostNumbersss = 105
            };
            context.Postnumbers.AddOrUpdate(
                p => p.PostNumbersss,
                pn1,
                pn2,
                pn3,
                pn4,
                pn5
            );
            context.SaveChanges();
            #endregion

            #region customers

            Customer c1 = new Customer()
            {
                Kennitala = "1511026547",
                Name = "Kalli karlsson",
                Email = "Kalli@gmail.com",
                Phone = "5885522"
            };
            Customer c2 = new Customer()
            {
                Kennitala = "2462147896",
                Name = "Gunnar Gúðjónsson",
                Email = "gunni@gmail.com",
                Phone = "5445522"
            };
            Customer c3 = new Customer()
            {
                Kennitala = "2504653256",
                Name = "Gunna Aðalsteinsdóttir",
                Email = "gunna@gmail.com",
                Phone = "5996633"
            };
            Customer c4 = new Customer()
            {
                Kennitala = "1404702390",
                Name = "Sunna Magnúsdóttir",
                Email = "sunna@gmail.com",
                Phone = "5812345"
            };
            Customer c5 = new Customer()
            {
                Kennitala = "2409354565",
                Name = "Jón jónsson",
                Email = "jón@gmail.com",
                Phone = "5115588"
            };
            context.Customers.AddOrUpdate(
                c => c.Name,
                c1,
                c2,
                c3,
                c4,
                c5
            );
            context.SaveChanges();
            #endregion

            #region Apartments

            Apartment ap1 = new Apartment()
            {
                address = "Kaldasel 25",
                Price = 25000000



            };
            Apartment ap2 = new Apartment()
            {
                address = "Flúðasel 10",
                Price = 35000000



            };
            Apartment ap3 = new Apartment()
            {
                address = "Hnjúkasel 32",
                Price = 40000000


            };
            Apartment ap4 = new Apartment()
            {
                address = "Arnarbakki 15",
                Price = 45000000



            };
            Apartment ap5 = new Apartment()
            {
                address = "Klukkusel 104",
                Price = 50000000


            };


            context.Apartments.AddOrUpdate(
                a => a.address,
                ap1,
                ap2,
                ap3,
                ap4,
                ap5
            );
            context.SaveChanges();



            //c1.Apartments.Add(ap1);
            //c2.Apartments.Add(ap2);
            //c3.Apartments.Add(ap3);
            //c4.Apartments.Add(ap4);
            //context.SaveChanges();
            #endregion

            #region Apartment Details


            ApartmentDetails ad1 = new ApartmentDetails()
            {
                Id = ap1.Id,
                Type = "Einbílishús",
                YearBuilt = 2005,
                ApartmentSize = 400,
                RoomsCount = 6,
                BedroomCount = 2,
                ToiletCount = 2,
                Entrance = "Ekki sameiginlegur",
                Garage = "Já",

            };
            ApartmentDetails ad2 = new ApartmentDetails()
            {
                Id = ap2.Id,
                Type = "Íbúð",
                YearBuilt = 2002,
                ApartmentSize = 200,
                RoomsCount = 4,
                BedroomCount = 1,
                ToiletCount = 1,
                Entrance = "sameiginlegur",
                Garage = "Nei",

            };
            ApartmentDetails ad3 = new ApartmentDetails()
            {
                Id = ap3.Id,
                Type = "Einbílishús",
                YearBuilt = 2000,
                ApartmentSize = 115,
                RoomsCount = 3,
                BedroomCount = 1,
                ToiletCount = 1,
                Entrance = "Ekki sameiginlegur",
                Garage = "Nei"
            };
            ApartmentDetails ad4 = new ApartmentDetails()
            {
                Id = ap4.Id,
                Type = "Íbúð",
                YearBuilt = 2010,
                ApartmentSize = 150,
                RoomsCount = 2,
                BedroomCount = 1,
                ToiletCount = 1,
                Entrance = "sameiginlegur",
                Garage = "Nei"
            };
            ApartmentDetails ad5 = new ApartmentDetails()
            {
                Id = ap5.Id,
                Type = "Einbílishús",
                YearBuilt = 2017,
                ApartmentSize = 600,
                RoomsCount = 10,
                BedroomCount = 5,
                ToiletCount = 4,
                Entrance = "Ekki sameiginlegur",
                Garage = "Ja"
            };
            context.ApartmentDetails.AddOrUpdate(
                ad => ad.RoomsCount,
                ad1,
                ad2,
                ad3,
                ad4,
                ad5
            );
            context.SaveChanges();

            ap1.ApartmentDetails = ad1;
            ap2.ApartmentDetails = ad2;
            ap3.ApartmentDetails = ad3;
            ap4.ApartmentDetails = ad4;
            ap5.ApartmentDetails = ad5;
            context.SaveChanges();

            ap1.PostNumber = pn1;
            ap2.PostNumber = pn2;
            ap3.PostNumber = pn3;
            ap4.PostNumber = pn4;
            ap5.PostNumber = pn5;
            context.SaveChanges();

            c1.ApartmentStuff = ap1;
            c2.ApartmentStuff = ap2;
            c3.ApartmentStuff = ap3;
            c4.ApartmentStuff = ap4;
            c5.ApartmentStuff = ap5;

            context.SaveChanges();



            //PostNumberTest pnt1 = new PostNumberTest()
            //{
            //    PNRT = 109
            //};
            //PostNumberTest pnt2 = new PostNumberTest()
            //{
            //    PNRT = 108

            //};
            //PostNumberTest pnt3 = new PostNumberTest()
            //{
            //    PNRT = 107
            //};
            //PostNumberTest pnt4 = new PostNumberTest()
            //{
            //    PNRT = 106
            //};
            //PostNumberTest pnt5 = new PostNumberTest()
            //{
            //    PNRT = 105
            //};

            //ap1.PnrTest = pnt1;
            //ap2.PnrTest = pnt2;
            //ap3.PnrTest = pnt3;
            //ap4.PnrTest = pnt4;
            //ap5.PnrTest = pnt5;

            context.SaveChanges();

            #endregion

            #region Apartment Problem

            ApartmentProblem aprob1 = new ApartmentProblem()
            {
                Problem = "Bilaður ofn",
            };
            ApartmentProblem aprob2 = new ApartmentProblem()
            {
                Problem = "Biluð loftræsing",
            };
            ApartmentProblem aprob3 = new ApartmentProblem()
            {
                Problem = "Brotin gluggi",
            };
            ApartmentProblem aprob4 = new ApartmentProblem()
            {
                Problem = "ónýtt ljós",
            };
            ApartmentProblem aprob5 = new ApartmentProblem()
            {
                Problem = "Allt í top standi",
            };

            ap1.ApartmentProblems = aprob1;
            ap2.ApartmentProblems = aprob2;
            ap3.ApartmentProblems = aprob3;
            ap4.ApartmentProblems = aprob4;
            ap5.ApartmentProblems = aprob5;
            context.SaveChanges();
            #endregion
        }
    }
}
