#include <iostream>
#include<cmath>
using namespace std;

int main()
{//ETHIOPIAN CALENDAR
    //Produced by {Dawit Girma}
// Date: October, 2022
   int month, year, month_days, evangelist, metene_rabiet, amete_alem, tinte_qemer;

   bool leap_year=false;

   cout<< "Please enter the year in E.C:\n";
   cin>>year;

 //check whether the year is valid

   while (year<=0)
  {
    cout<<"wrong entry.\n";


   cout<<"please enter the year starting from 1\n";
   cin>>year;
  }
  // calculating amete_alem

  amete_alem=5500+year;
  // finding metene_rabiet

   metene_rabiet=amete_alem/4;
   // find the evangelist

       evangelist= amete_alem%4;
       //checking leap year

       if(evangelist==3)
        leap_year=true;

        // Initialize the month to September

        month=1 ;
        // display month name

        while(month<=13)
        {
            if(month==1)
               {

                cout<<endl<<"September"<<endl;
                cout<<"=========="<<endl;
               }
            else if(month==2)
               {

                cout<<endl<<"October"<<endl;
                cout<<"=========="<<endl;
               }
            else if(month==3)
                {
                cout<<endl<<"November"<<endl;
                cout<<"=========="<<endl;
                }
            else if(month==4)
                {
                cout<<endl<<"December"<<endl;
                cout<<"=========="<<endl;
                }
            else if(month==5)
                {

                cout<<endl<<"January"<<endl;
                cout<<"=========="<<endl;
                }
            else if(month==6)
                {
                cout<<endl<<"February"<<endl;
                cout<<"=========="<<endl;
                }
            else if(month==7)
                {
                cout<<endl<<"March"<<endl;
                cout<<"=========="<<endl;
                }
            else if(month==8)
                {
                cout<<endl<<"April"<<endl;
                cout<<"=========="<<endl;
                }
            else if(month==9)
                {
                cout<<endl<<"May"<<endl;
                cout<<"=========="<<endl;
                }
            else if(month==10)
                {
                cout<<endl<<"June"<<endl;
                cout<<"=========="<<endl;
                }
            else if(month==11)
                {
                cout<<endl<<"July"<<endl;
                cout<<"=========="<<endl;
                }
            else if(month==12)
                {
                cout<<endl<<"August"<<endl;
                cout<<"=========="<<endl;
                }
            else if(month==13)
                {
                cout<<endl<<"Pagume"<<endl;
                cout<<"=========="<<endl;
                }
                // get the number of days for each month in year

            switch(month)
            {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
                month_days=30;
                break;

            case 13:
                if(leap_year)
                    month_days=6;
                else
                    month_days=5;

            }
             // calculating tinte_qemer

             tinte_qemer=(amete_alem+metene_rabiet)%7;
             // computing the first day for each month

                if( month>=1)
                 {
                    //using arithmetic sequence
                     tinte_qemer= tinte_qemer+ 2*(month-1);
                 tinte_qemer= tinte_qemer%7;
                 }



            cout<<"\nMon\tTue\tWed\tThu\tFri\tSat\tSun\n";
// space up to the first day of month

            for(int i=0; i<tinte_qemer; i++)
                cout<<"\t";
// display the calendar of each month

            for(int j=1; j<=month_days; j++)
               {

               cout<<j<<"\t";
               tinte_qemer++;
               if(tinte_qemer%7==0)
                cout<<endl;
               }
// update month number

               month++;

        }






    return 0;
}
