
using Smart_Parking_Lot_System.SPL_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Parking_Lot_System.SPL_UI
{
    public class SPLUI
    {

       public void ui()
        {


            CarOwnerInfoBLL carOwnerInfoBLL = new CarOwnerInfoBLL();
            VahicleInfoBLL vahicleInfoBLL = new VahicleInfoBLL();
            EntryDateTimeBLL entryDateTimeBLL = new EntryDateTimeBLL();
            ExitDateTimeBLL exitDateTimeBLL = new ExitDateTimeBLL();

            int num;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Car Owner Info");
                Console.WriteLine("2. Vahicle");
                Console.WriteLine("3. Entry Date And Time");
                Console.WriteLine("4. Exit Date And Time");
                Console.WriteLine("5. Full List");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your Choice = ");
                num = Convert.ToInt32(Console.ReadLine());

                if(num == 1)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("-----Menu-----");
                        Console.WriteLine("1. Add");
                        Console.WriteLine("2. Delete");
                        Console.WriteLine("3. Update");
                        Console.WriteLine("4. ALL Owner List");
                        Console.WriteLine("5. Back");
                        Console.WriteLine();
                        Console.Write("Enter your Choice = ");
                        num = Convert.ToInt32(Console.ReadLine());

                        switch (num)
                        {
                            case 1:

                                carOwnerInfoBLL.carOwnerAdd();

                                break;

                            case 2:
                                carOwnerInfoBLL.carOwnerDelete();



                                break;

                            case 3:

                                carOwnerInfoBLL.carOwnerUpdate();

                                break;

                            case 4:
                                carOwnerInfoBLL.carOwnerGetAll();


                                break;

                           
                        }
                    } while (num != 5);
                    
                   
                }
                else if(num == 2)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("-----Menu-----");
                        Console.WriteLine("1. Add");
                        Console.WriteLine("2. Update");
                        Console.WriteLine("3. Vahicle List");
                        Console.WriteLine("4. Back");
                        Console.WriteLine();
                        Console.Write("Enter your Choice = ");
                        num = Convert.ToInt32(Console.ReadLine());

                        switch (num)
                        {
                            case 1:


                                vahicleInfoBLL.vahicleAdd();
                                break;

                            case 2:

                                vahicleInfoBLL.vahicleUpdate();
                              

                                break;

                            case 3:

                                vahicleInfoBLL.vahicleGetAll();

                                break;

                            //case 4:


                            //    break;

                        }
                    } while (num != 4);
                    
                }
                else if(num == 3)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("-----Menu-----");
                        Console.WriteLine("1. Add");
                        Console.WriteLine("2. Update");
                        Console.WriteLine("3. Entey List");
                        Console.WriteLine("4. Back");
                        Console.WriteLine();
                        Console.Write("Enter your Choice = ");
                        num = Convert.ToInt32(Console.ReadLine());

                        switch (num)
                        {
                            case 1:

                                entryDateTimeBLL.EntryDateTimeAdd();

                                break;

                            case 2:


                                entryDateTimeBLL.EntryDateTimeUpdate();
                                break;

                            case 3:

                                entryDateTimeBLL.EntryDateTimeGetAll();

                                break;

                            //case 4:

                               

                            //    break;

                           
                        }
                    } while (num != 4);
                    
                }
                else if (num == 4)
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("-----Menu-----");
                        Console.WriteLine("1. Add");
                        Console.WriteLine("2. select List");
                        Console.WriteLine("3. delete Parking");
                        Console.WriteLine("4. Back");
                        Console.WriteLine();
                        Console.Write("Enter your Choice = ");
                        num = Convert.ToInt32(Console.ReadLine());

                        switch (num)
                        {
                            case 1:

                                exitDateTimeBLL.exitDateAdd();

                                break;

                            case 2:

                                exitDateTimeBLL.selectView();

                                break;

                            case 3:

                                exitDateTimeBLL.deleteParking();

                                break;

                                //case 4:




                                //    break;

                        }
                    } while (num != 4);

                }
                else if(num == 5)
                {
                    Console.WriteLine("------ All Info List -----");
                    exitDateTimeBLL.allList();
                }



            }
            while (num != 6);
        }

        
    }
}
