
using System.Collections.Generic;
using System.Data.Entity;
using RestaurantMvc.Model.Models;


namespace RestaurantMvc.Data
{
    public class RestaurantTablesSeedData : DropCreateDatabaseIfModelChanges<ReservationContext>
    {
        protected override void Seed(ReservationContext context)
        {
            GetTableses().ForEach(c => context.Tableses.Add(c));
            GetMenuCategory().ForEach(c => context.MenuCategories.Add(c));
            GetMenuDisheses().ForEach(c => context.MenuDisheses.Add(c));
            context.Commit();
        }

        public static List<MenuCategory> GetMenuCategory()
        {
            return new List<MenuCategory>
            {
               new MenuCategory { Name = "Zupy"},
               new MenuCategory {Name = "Miesa"},
               new MenuCategory {Name = "Przystawki"},
               new MenuCategory {Name = "Ryby i owoce morza"},
               new MenuCategory {Name = "Salaty"},
               new MenuCategory {Name = "Makarony"},
               new MenuCategory {Name = "Pizza"},
               new MenuCategory {Name = "Desery"}
            };
        }

        public static List<MenuDishes> GetMenuDisheses()
        {
            return new List<MenuDishes>
            {
                new MenuDishes {CategoryId = 1,
                    Name = "PIKANTNA ZUPA RYBNA Z OWOCAMI MORZA",
                    Description ="(zupa na wywarze z łososia z pomidorami pelatti, włoszczyzną,\r\ncebulą, czosnkiem, dorszem, krewetkami oraz mięsem małż\r\ni natką pietruszki)",
                    Price=26
                },
                new MenuDishes
                {
                    CategoryId = 1,
                    Name = "KREM Z WARZYW SEZONOWYCH",
                    Description = "(przygotowany na wywarze z włoszczyzny – zapytaj o aktualną propozycję)",
                    Price = 18
                },
                new MenuDishes
                {
                    CategoryId = 1,
                    Name = "BULION DROBIOWY Z MAKARONEM",
                    Description= "(klarowny bulion z włoszczyzną, cebulą i makaronem oraz natką pietruszki i serem Grana Padano)",
                    Price = 19
                },
                new MenuDishes
                {
                    CategoryId = 2,
                    Name = "STEK TOMAHAWK",
                    Description = "Waga steków od 800g (dojrzewająca wołowina, zapeklowana w ziołach, podawana z masłem czosnkowym i solą w płatkach)",
                    Price = 16
                },
                new MenuDishes
                {
                    CategoryId = 2,
                    Name = "STEK Z POLĘDWICY WOŁOWEJ (250g)",
                    Description = "(polędwica wołowa – 250g* podana z rukolą i pomidorkiem cherry, do wyboru sosy: z zielonego pieprzu, ziołowo-oliwny lub truflowy) *podane gramatury mięs są wartościami przed wysmażeniem, podczas obróbki mięso w zależności od stopnia wysmażenia może utracić do 45% wartości",
                    Price = 65
                },
                new MenuDishes
                {
                    CategoryId = 2,
                    Name = "STEK Z ANTRYKOTU (350g)",
                    Description = "(antrykot – 350 g* podany z rukolą i pomidorkiem cherry, do wyboru sosy: masło czosnkowe lub ziołowo-oliwny) *podane gramatury mięs są wartościami przed wysmażeniem, podczas obróbki mięso w zależności od stopnia wysmażenia może utracić do 45% wartości",
                    Price = 65
                },
                new MenuDishes
                {
                    CategoryId = 3,
                    Name = "SER CAMEMBERT Z PIECA W CIEŚCIE FILLO",
                    Description = "(ser camembert w cieście fillo z orzechami laskowymi, miodem, masłem oraz dressingiem owocowym i gruszką)",
                    Price = 29
                },
                new MenuDishes
                {
                    CategoryId = 3,
                    Name = "MOZZARELLA AL FORNO",
                    Description = "(mozzarella z szynką Prosciutto Crudo zapieczona w piecu opalanym drewnem z rukolą, pomidorkiem cherry i dressingiem bazyliowym)",
                    Price = 28
                },
                new MenuDishes
                {
                    CategoryId = 3,
                    Name = "CARPACCIO WOŁOWE",
                    Description = "(cienko krojone plastry polędwicy wołowej z oliwą, cytryną,suszonymi pomidorami, rukolą i płatkami Grana Padano)",
                    Price = 35
                },
                new MenuDishes
                {
                    CategoryId = 4,
                    Name = "STEK Z KAŁAMARNICY",
                    Description = "(Kałamarnica z pomidorkami cherry, kaparami, czosnkiem i natką pietruszki, z dodatkiem masła, bulionu i białego wina)",
                    Price = 49
                },
                new MenuDishes
                {
                    CategoryId = 4,
                    Name = "DORADA Z PIECA",
                    Description = "(dorada pieczona w piecu opalanym drewnem z ziołami, czosnkiem, cytryną i masłem oraz dressingiem bazyliowym, podana z rukolą)",
                    Price = 45
                },
                new MenuDishes
                {
                    CategoryId = 4,
                    Name = "FILET Z PSTRĄGA",
                    Description = "(filet z pstrąga z sosem miodowo-musztardowym oraz cytryną z pieca opalanego drewnem, podany z rukolą)",
                    Price = 39
                },
                new MenuDishes
                {
                    CategoryId = 5,
                    Name = "INSTALATA CON CICIORIA",
                    Description = "(Cykoria z gruszką i serem gorgonzola ze szczypiorkiem i dressingiem miodowo – cytrynowym)",
                    Price = 34
                },
                new MenuDishes
                {
                    CategoryId = 5,
                    Name = "INSALATA CON CARNE",
                    Description = "(mix sałat z wołowiną medium, cebulą, pomidorkami cherry oraz dressingiem musztardowym)",
                    Price = 36
                },
                new MenuDishes
                {
                    CategoryId = 5,
                    Name = "INSALATA CON OCHE",
                    Description = "(mix sałat z wędzoną piersią gęsi, gruszką,prażonymi orzeszkami pinii oraz dressingiem malinowym)",
                    Price = 34
                },
                new MenuDishes
                {
                    CategoryId = 6,
                    Name = "FUSILLI CON TONNO",
                    Description = "(makaron barwiony sepią z mątwy w sosie pomidrowym z kawałkami tuńczyka marynowanego w oleju z pomidorkami cherry, kaparami, anchois, Grana Padano i rukolą",
                    Price = 35
                },
                new MenuDishes
                {
                    CategoryId = 6,
                    Name = "TAGLIATELLE BOLOGNESE",
                    Description = "(Makaron z ragu wołowo – wieprzowym na bazie czerwonego wina, sosu pomidorowego z kaparami, oliwkami, serem Grana Padano, selerem naciowym i natką pietruszki)",
                    Price = 36
                },
                new MenuDishes
                {
                    CategoryId = 6,
                    Name = "TAGLIATELLE CON FRUTTI DI MARE",
                    Description = "(tagliatelle nero – barwione sepią mątwy, z krewetkami, mięsem małż, oliwą, bazylią, czosnkiem, Garana Padano, peperoncino i pomidorkami cherry)",
                    Price = 38
                },
                new MenuDishes
                {
                    CategoryId = 7,
                    Name = "MARGHERITA",
                    Description = "(placek pizzowy, sos pomidorowy, mozzarella, bazylia, oliwa, oregano)",
                    Price = 27
                },
                new MenuDishes
                {
                    CategoryId = 7,
                    Name = "DIAVOLA",
                    Description = "(placek pizzowy, sos pomidorowy, mozzarella, salami pikantne, oliwa, oregano)",
                    Price = 33
                },
                new MenuDishes
                {
                    CategoryId = 7,
                    Name = "RAFFINATA",
                    Description = "(placek pizzowy, sos pomidorowy, mozzarella, szynka Prosciutto Crudo, rukola, płatki Grana Padano, oliwa, oregano)",
                    Price = 35
                },
                new MenuDishes
                {
                    CategoryId = 8,
                    Name = "GNIECIONY ZIEMNIAK",
                    Description = "(Ziemniak z oliwą, natką pietruszki, czosnkiem i oliwkami)",
                    Price = 9
                },
                new MenuDishes
                {
                    CategoryId = 8,
                    Name = "WARZYWA KORZENIOWE",
                    Description = "(Marchew i pietruszka z patelni przygotowane ze świeżymi ziołami, masłem i miodem oraz natką pietruszki)",
                    Price = 9
                },
                new MenuDishes
                {
                    CategoryId = 8,
                    Name = "SZPINAK",
                    Description = "(blanszowane liście szpinaku przygotowane z masłem, czosnkiem, sokiem z cytryny, śmietaną i Grana Padano)",
                    Price = 12
                }
            };
        }


        public static List<Table> GetTableses()
        {
            return new List<Table>{
                new Table()
                {
                    TableId=1,
                    Capacity=2
                },
                  new Table()
                {
                    TableId=2,
                    Capacity=2
                },
                    new Table()
                {
                    TableId=3,
                    Capacity=4
                },
                      new Table()
                {
                    TableId=4,
                    Capacity=4
                },
                        new Table()
                {
                    TableId=5,
                    Capacity=4
                },
                          new Table()
                {
                    TableId=6,
                    Capacity=4
                },
                          new Table()
                {
                    TableId=7,
                    Capacity=6
                },
                            new Table()
                {
                    TableId=8,
                    Capacity=8
                },
            };
        }
    }
}
