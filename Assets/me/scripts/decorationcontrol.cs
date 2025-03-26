using System;
using UnityEngine;

namespace LoGaCulture.LUTE
{
    public class decorationcontrol : MonoBehaviour
    {
        public GameObject backgroundred1;
        public GameObject backgroundred2;
        public GameObject backgroundorange1;
        public GameObject backgroundorange2;
        public GameObject backgroundyellow1;
        public GameObject backgroundyellow2;
        public GameObject backgroundgreen1;
        public GameObject backgroundgreen2;
        public GameObject backgroundblue1;
        public GameObject backgroundblue2;
        public GameObject backgroundpurple1;
        public GameObject backgroundpurple2;

        public GameObject spotsblack1;
        public GameObject spotsblack2;
        public GameObject spotswhite1;
        public GameObject spotswhite2;
        public GameObject spotsred1;
        public GameObject spotsred2;
        public GameObject spotsorange1;
        public GameObject spotsorange2;
        public GameObject spotsyellow1;
        public GameObject spotsyellow2;
        public GameObject spotsgreen1;
        public GameObject spotsgreen2;
        public GameObject spotsblue1;
        public GameObject spotsblue2;
        public GameObject spotspurple1;
        public GameObject spotspurple2;

        public GameObject stripesblack1;
        public GameObject stripesblack2;
        public GameObject stripeswhite1;
        public GameObject stripeswhite2;
        public GameObject stripesred1;
        public GameObject stripesred2;
        public GameObject stripesorange1;
        public GameObject stripesorange2;
        public GameObject stripesyellow1;
        public GameObject stripesyellow2;
        public GameObject stripesgreen1;
        public GameObject stripesgreen2;
        public GameObject stripesblue1;
        public GameObject stripesblue2;
        public GameObject stripespurple1;
        public GameObject stripespurple2;

        public GameObject diamondsblack1;
        public GameObject diamondsblack2;
        public GameObject diamondswhite1;
        public GameObject diamondswhite2;
        public GameObject diamondsred1;
        public GameObject diamondsred2;
        public GameObject diamondsorange1;
        public GameObject diamondsorange2;
        public GameObject diamondsyellow1;
        public GameObject diamondsyellow2;
        public GameObject diamondsgreen1;
        public GameObject diamondsgreen2;
        public GameObject diamondsblue1;
        public GameObject diamondsblue2;
        public GameObject diamondspurple1;
        public GameObject diamondspurple2;

        public GameObject rainbow1;
        public GameObject rainbow2;
        public bool rainbow1on;
        public bool rainbow2on;

        public GameObject rock1;
        public GameObject rock2;
        public bool rock1on;
        public bool rock2on;

        public GameObject sheep1;
        public GameObject sheep2;
        public bool sheep1on;
        public bool sheep2on;


        public GameObject spots1;
        public GameObject spots2;
        public GameObject spotscolour1;
        public GameObject spotscolour2;
        public bool spots1on;
        public bool spots2on;

        public GameObject stripes1;
        public GameObject stripes2;
        public bool stripes1on;
        public bool stripes2on;
       


        public GameObject diamond1;
        public GameObject diamond2;
        public bool diamond1on;
        public bool diamond2on;
       

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            backgroundred1.SetActive(true);
            backgroundred2.SetActive(true);

            //spots1on = false;
            //spots2on = false;
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Reset()
        {
            spots1.SetActive(false);
            spotscolour1.SetActive(false);
            spots1on = false;
            stripes1.SetActive(false);
            stripes1on = false;
            diamond1.SetActive(false);
            diamond1on = false;
            rainbow1.SetActive(false);
            rainbow1on = false;
            rock1.SetActive(false);
            rock1on = false;
            sheep1.SetActive(false);
            sheep1on = false;
            
            spots2.SetActive(false);
            spotscolour2.SetActive(false);
            spots2on = false;
            stripes2.SetActive(false);
            stripes2on = false;
            diamond2.SetActive(false);
            diamond2on = false;
            rainbow2.SetActive(false);
            rainbow2on = false;
            rock2.SetActive(false);
            rock2on = false;
            sheep2.SetActive(false);
            sheep2on = false;

        }

        //choose background colour
        public void chosered1()
        {
            backgroundred1.SetActive(true);

            backgroundorange1.SetActive(false);
            backgroundyellow1.SetActive(false);
            backgroundgreen1.SetActive(false);
            backgroundblue1.SetActive(false);
            backgroundpurple1.SetActive(false);

        }
        public void chosered2()
        {
            backgroundred2.SetActive(true);

            backgroundorange2.SetActive(false);
            backgroundyellow2.SetActive(false);
            backgroundgreen2.SetActive(false);
            backgroundblue2.SetActive(false);
            backgroundpurple2.SetActive(false);

        }
        public void choseorange1()
        {
            backgroundorange1.SetActive(true);

            backgroundred1.SetActive(false);
            backgroundyellow1.SetActive(false);
            backgroundgreen1.SetActive(false);
            backgroundblue1.SetActive(false);
            backgroundpurple1.SetActive(false);
        }
        public void choseorange2()
        {
            backgroundorange2.SetActive(true);

            backgroundred2.SetActive(false);
            backgroundyellow2.SetActive(false);
            backgroundgreen2.SetActive(false);
            backgroundblue2.SetActive(false);
            backgroundpurple2.SetActive(false);
        }
        public void choseyellow1()
        {
            backgroundyellow1.SetActive(true);

            backgroundorange1.SetActive(false);
            backgroundred1.SetActive(false);
            backgroundgreen1.SetActive(false);
            backgroundblue1.SetActive(false);
            backgroundpurple1.SetActive(false);
        }
        public void choseyellow2()
        {
            backgroundyellow2.SetActive(true);

            backgroundorange2.SetActive(false);
            backgroundred2.SetActive(false);
            backgroundgreen2.SetActive(false);
            backgroundblue2.SetActive(false);
            backgroundpurple2.SetActive(false);
        }
        public void chosegreen()
        {
            backgroundgreen1.SetActive(true);

            backgroundorange1.SetActive(false);
            backgroundyellow1.SetActive(false);
            backgroundred1.SetActive(false);
            backgroundblue1.SetActive(false);
            backgroundpurple1.SetActive(false);
        }
        public void chosegreen2()
        {
            backgroundgreen2.SetActive(true);

            backgroundorange2.SetActive(false);
            backgroundyellow2.SetActive(false);
            backgroundred2.SetActive(false);
            backgroundblue2.SetActive(false);
            backgroundpurple2.SetActive(false);
        }
        public void choseblue1()
        {
            backgroundblue1.SetActive(true);

            backgroundorange1.SetActive(false);
            backgroundyellow1.SetActive(false);
            backgroundgreen1.SetActive(false);
            backgroundred1.SetActive(false);
            backgroundpurple1.SetActive(false);
        }
        public void choseblue2()
        {
            backgroundblue2.SetActive(true);

            backgroundorange2.SetActive(false);
            backgroundyellow2.SetActive(false);
            backgroundgreen2.SetActive(false);
            backgroundred2.SetActive(false);
            backgroundpurple2.SetActive(false);
        }
        public void chosepurple1()
        {
            backgroundpurple1.SetActive(true);

            backgroundorange1.SetActive(false);
            backgroundyellow1.SetActive(false);
            backgroundgreen1.SetActive(false);
            backgroundblue1.SetActive(false);
            backgroundred1.SetActive(false);
        }
        public void chosepurple2()
        {
            backgroundpurple2.SetActive(true);

            backgroundorange2.SetActive(false);
            backgroundyellow2.SetActive(false);
            backgroundgreen2.SetActive(false);
            backgroundblue2.SetActive(false);
            backgroundred2.SetActive(false);
        }
        //choose spots and display colour options
        public void showspots1()
        {
            if (spots1on == false)
            {
                spots1.SetActive(true);
                spotscolour1.SetActive(true);
                spots1on = true;

                stripes1.SetActive(false);
                stripes1on = false;
                diamond1.SetActive(false);
                diamond1on = false;
                rainbow1.SetActive(false);
                rainbow1on = false;
                rock1.SetActive(false);
                rock1on = false;
                sheep1.SetActive(false);
                sheep1on = false;
            }
            else if (spots1on == true)
            {
                spots1.SetActive(false);
                spotscolour1.SetActive(false);
                spots1on = false;
            }


        }

        public void showspots2()
        {
            if (spots2on == false)
            {
                spots2.SetActive(true);
                spotscolour2.SetActive(true);
                spots2on = true;

                stripes2.SetActive(false);
                stripes2on = false;
                diamond2.SetActive(false);
                diamond2on = false;
                rainbow2.SetActive(false);
                rainbow2on = false;
                rock2.SetActive(false);
                rock2on = false;
                sheep2.SetActive(false);
                sheep2on = false;
            }
            else if (spots2on == true)
            {
                spots2.SetActive(false);
                spotscolour2.SetActive(false);
                spots2on = false;
            }
        }

        //choose spot colour

        public void blackspots1()
        {
            spotsblack1.SetActive(true);

            spotswhite1.SetActive(false);
            spotsred1.SetActive(false);
            spotsorange1.SetActive(false);
            spotsyellow1.SetActive(false);
            spotsgreen1.SetActive(false);
            spotsblue1.SetActive(false);
            spotspurple1.SetActive(false);
        }
        public void whitespots1()
        {
            spotswhite1.SetActive(true);

            spotsblack1.SetActive(false);
            spotsred1.SetActive(false);
            spotsorange1.SetActive(false);
            spotsyellow1.SetActive(false);
            spotsgreen1.SetActive(false);
            spotsblue1.SetActive(false);
            spotspurple1.SetActive(false);
        }
        public void redpots1()
        {
            spotsred1.SetActive(true);

            spotswhite1.SetActive(false);
            spotsblack1.SetActive(false);
            spotsorange1.SetActive(false);
            spotsyellow1.SetActive(false);
            spotsgreen1.SetActive(false);
            spotsblue1.SetActive(false);
            spotspurple1.SetActive(false);
        }
        public void orangepots1()
        {
            spotsorange1.SetActive(true);

            spotswhite1.SetActive(false);
            spotsblack1.SetActive(false);
            spotsred1.SetActive(false);
            spotsyellow1.SetActive(false);
            spotsgreen1.SetActive(false);
            spotsblue1.SetActive(false);
            spotspurple1.SetActive(false);
        }
        public void yellowpots1()
        {
            spotsyellow1.SetActive(true);

            spotswhite1.SetActive(false);
            spotsblack1.SetActive(false);
            spotsorange1.SetActive(false);
            spotsred1.SetActive(false);
            spotsgreen1.SetActive(false);
            spotsblue1.SetActive(false);
            spotspurple1.SetActive(false);
        }
        public void greenpots1()
        {
            spotsgreen1.SetActive(true);

            spotswhite1.SetActive(false);
            spotsblack1.SetActive(false);
            spotsorange1.SetActive(false);
            spotsyellow1.SetActive(false);
            spotsred1.SetActive(false);
            spotsblue1.SetActive(false);
            spotspurple1.SetActive(false);
        }
        public void bluepots1()
        {
            spotsblue1.SetActive(true);

            spotswhite1.SetActive(false);
            spotsblack1.SetActive(false);
            spotsorange1.SetActive(false);
            spotsyellow1.SetActive(false);
            spotsgreen1.SetActive(false);
            spotsred1.SetActive(false);
            spotspurple1.SetActive(false);
        }
        public void purplepots1()
        {
            spotspurple1.SetActive(true);

            spotswhite1.SetActive(false);
            spotsblack1.SetActive(false);
            spotsorange1.SetActive(false);
            spotsyellow1.SetActive(false);
            spotsgreen1.SetActive(false);
            spotsblue1.SetActive(false);
            spotsred1.SetActive(false);
        }
        public void blackspots2()
        {
            spotsblack2.SetActive(true);

            spotswhite2.SetActive(false);
            spotsred2.SetActive(false);
            spotsorange2.SetActive(false);
            spotsyellow2.SetActive(false);
            spotsgreen2.SetActive(false);
            spotsblue2.SetActive(false);
            spotspurple2.SetActive(false);
        }
        public void whitespots2()
        {
            spotswhite2.SetActive(true);

            spotsblack2.SetActive(false);
            spotsred2.SetActive(false);
            spotsorange2.SetActive(false);
            spotsyellow2.SetActive(false);
            spotsgreen2.SetActive(false);
            spotsblue2.SetActive(false);
            spotspurple2.SetActive(false);
        }
        public void redspots2()
        {
            spotsred2.SetActive(true);

            spotswhite2.SetActive(false);
            spotsred2.SetActive(false);
            spotsorange2.SetActive(false);
            spotsyellow2.SetActive(false);
            spotsgreen2.SetActive(false);
            spotsblue2.SetActive(false);
            spotspurple2.SetActive(false);
        }
        public void orangespots2()
        {
            spotsorange2.SetActive(true);

            spotswhite2.SetActive(false);
            spotsred2.SetActive(false);
            spotsblack2.SetActive(false);
            spotsyellow2.SetActive(false);
            spotsgreen2.SetActive(false);
            spotsblue2.SetActive(false);
            spotspurple2.SetActive(false);
        }
        public void yellowspots2()
        {
            spotsyellow2.SetActive(true);

            spotswhite2.SetActive(false);
            spotsred2.SetActive(false);
            spotsorange2.SetActive(false);
            spotsblack2.SetActive(false);
            spotsgreen2.SetActive(false);
            spotsblue2.SetActive(false);
            spotspurple2.SetActive(false);
        }
        public void greenspots2()
        {
            spotsgreen2.SetActive(true);

            spotswhite2.SetActive(false);
            spotsred2.SetActive(false);
            spotsorange2.SetActive(false);
            spotsyellow2.SetActive(false);
            spotsblack2.SetActive(false);
            spotsblue2.SetActive(false);
            spotspurple2.SetActive(false);
        }
        public void bluespots2()
        {
            spotsblue2.SetActive(true);

            spotswhite2.SetActive(false);
            spotsred2.SetActive(false);
            spotsorange2.SetActive(false);
            spotsyellow2.SetActive(false);
            spotsgreen2.SetActive(false);
            spotsblack2.SetActive(false);
            spotspurple2.SetActive(false);
        }
        public void purplespots2()
        {
            spotspurple2.SetActive(true);

            spotswhite2.SetActive(false);
            spotsred2.SetActive(false);
            spotsorange2.SetActive(false);
            spotsyellow2.SetActive(false);
            spotsgreen2.SetActive(false);
            spotsblue2.SetActive(false);
            spotsblack2.SetActive(false);
        }

        //set stripes active
        public void showstripes1()
        {
            if (stripes1on == false)
            {
                stripes1.SetActive(true);
                spotscolour1.SetActive(true);
                stripes1on = true;

                spots1.SetActive(false);
                spots1on = false;
                diamond1.SetActive(false);
                diamond1on = false;
                rainbow1.SetActive(false);
                rainbow1on = false;
                rock1.SetActive(false);
                rock1on = false;
                sheep1.SetActive(false);
                sheep1on = false;
            }
            else if (stripes1on == true)
            {
                stripes1.SetActive(false);
                spotscolour1.SetActive(false);
                stripes1on = false;
            }
        }

        public void showstripes2()
        {
            if (stripes2on == false)
            {
                stripes2.SetActive(true);
                spotscolour2.SetActive(true);
                stripes2on = true;

                spots2.SetActive(false);
                spots2on = false;
                diamond2.SetActive(false);
                diamond2on = false;
                rainbow2.SetActive(false);
                rainbow2on = false;
                rock2.SetActive(false);
                rock2on = false;
                sheep2.SetActive(false);
                sheep2on = false;
            }
            else if (stripes2on == true)
            {
                stripes2.SetActive(false);
                spotscolour2.SetActive(false);
                stripes2on = false;
            }
        }

        //set stripe colour

        public void stripe1black()
        {
            stripesblack1.SetActive(true);

            stripeswhite1.SetActive(false);
            stripesred1.SetActive(false);
            stripesorange1.SetActive(false);
            stripesyellow1.SetActive(false);
            stripesgreen1.SetActive(false);
            stripesblue1.SetActive(false);
            stripespurple1.SetActive(false);
        }
        public void stripe1white()
        {
            stripeswhite1.SetActive(true);

            stripesblack1.SetActive(false);
            stripesred1.SetActive(false);
            stripesorange1.SetActive(false);
            stripesyellow1.SetActive(false);
            stripesgreen1.SetActive(false);
            stripesblue1.SetActive(false);
            stripespurple1.SetActive(false);
        }
        public void stripe1red()
        {
            stripesred1.SetActive(true);

            stripeswhite1.SetActive(false);
            stripesblack1.SetActive(false);
            stripesorange1.SetActive(false);
            stripesyellow1.SetActive(false);
            stripesgreen1.SetActive(false);
            stripesblue1.SetActive(false);
            stripespurple1.SetActive(false);
        }
        public void stripe1orange()
        {
            stripesorange1.SetActive(true);

            stripeswhite1.SetActive(false);
            stripesred1.SetActive(false);
            stripesblack1.SetActive(false);
            stripesyellow1.SetActive(false);
            stripesgreen1.SetActive(false);
            stripesblue1.SetActive(false);
            stripespurple1.SetActive(false);
        }
        public void stripe1yellow()
        {
            stripesyellow1.SetActive(true);

            stripeswhite1.SetActive(false);
            stripesred1.SetActive(false);
            stripesorange1.SetActive(false);
            stripesblack1.SetActive(false);
            stripesgreen1.SetActive(false);
            stripesblue1.SetActive(false);
            stripespurple1.SetActive(false);
        }
        public void stripe1green()
        {
            stripesgreen1.SetActive(true);

            stripeswhite1.SetActive(false);
            stripesred1.SetActive(false);
            stripesorange1.SetActive(false);
            stripesyellow1.SetActive(false);
            stripesblack1.SetActive(false);
            stripesblue1.SetActive(false);
            stripespurple1.SetActive(false);
        }
        public void stripe1blue()
        {
            stripesblue1.SetActive(true);

            stripeswhite1.SetActive(false);
            stripesred1.SetActive(false);
            stripesorange1.SetActive(false);
            stripesyellow1.SetActive(false);
            stripesgreen1.SetActive(false);
            stripesblack1.SetActive(false);
            stripespurple1.SetActive(false);
        }
        public void stripe1purple()
        {
            stripespurple1.SetActive(true);

            stripeswhite1.SetActive(false);
            stripesred1.SetActive(false);
            stripesorange1.SetActive(false);
            stripesyellow1.SetActive(false);
            stripesgreen1.SetActive(false);
            stripesblue1.SetActive(false);
            stripesblack1.SetActive(false);
        }
        public void stripe2black()
        {
            stripesblack2.SetActive(true);

            stripeswhite2.SetActive(false);
            stripesred2.SetActive(false);
            stripesorange2.SetActive(false);
            stripesyellow2.SetActive(false);
            stripesgreen2.SetActive(false);
            stripesblue2.SetActive(false);
            stripespurple2.SetActive(false);
        }
        public void stripe2white()
        {
            stripeswhite2.SetActive(true);

            stripesblack2.SetActive(false);
            stripesred2.SetActive(false);
            stripesorange2.SetActive(false);
            stripesyellow2.SetActive(false);
            stripesgreen2.SetActive(false);
            stripesblue2.SetActive(false);
            stripespurple2.SetActive(false);
        }
        public void stripe2red()
        {
            stripesred2.SetActive(true);

            stripeswhite2.SetActive(false);
            stripesblack2.SetActive(false);
            stripesorange2.SetActive(false);
            stripesyellow2.SetActive(false);
            stripesgreen2.SetActive(false);
            stripesblue2.SetActive(false);
            stripespurple2.SetActive(false);
        }
        public void stripe2orange()
        {
            stripesorange2.SetActive(true);

            stripeswhite2.SetActive(false);
            stripesred2.SetActive(false);
            stripesblack2.SetActive(false);
            stripesyellow2.SetActive(false);
            stripesgreen2.SetActive(false);
            stripesblue2.SetActive(false);
            stripespurple2.SetActive(false);
        }
        public void stripe2yellow()
        {
            stripesyellow2.SetActive(true);

            stripeswhite2.SetActive(false);
            stripesred2.SetActive(false);
            stripesorange2.SetActive(false);
            stripesblack2.SetActive(false);
            stripesgreen2.SetActive(false);
            stripesblue2.SetActive(false);
            stripespurple2.SetActive(false);
        }
        public void stripe2green()
        {
            stripesgreen2.SetActive(true);

            stripeswhite2.SetActive(false);
            stripesred2.SetActive(false);
            stripesorange2.SetActive(false);
            stripesyellow2.SetActive(false);
            stripesblack2.SetActive(false);
            stripesblue2.SetActive(false);
            stripespurple2.SetActive(false);
        }
        public void stripe2blue()
        {
            stripesblue2.SetActive(true);

            stripeswhite2.SetActive(false);
            stripesred2.SetActive(false);
            stripesorange2.SetActive(false);
            stripesyellow2.SetActive(false);
            stripesgreen2.SetActive(false);
            stripesblack2.SetActive(false);
            stripespurple2.SetActive(false);
        }
        public void stripe2purple()
        {
            stripespurple2.SetActive(true);

            stripeswhite2.SetActive(false);
            stripesred2.SetActive(false);
            stripesorange2.SetActive(false);
            stripesyellow2.SetActive(false);
            stripesgreen2.SetActive(false);
            stripesblue2.SetActive(false);
            stripesblack2.SetActive(false);
        }

        //show diamond
        public void showdiamond1()
        {
            if (diamond1on == false)
            {
                diamond1.SetActive(true);
                spotscolour1.SetActive(true);
                diamond1on = true;

                spots1.SetActive(false);
                spots1on = false;
                stripes1.SetActive(false);
                stripes1on = false;
                rainbow1.SetActive(false);
                rainbow1on = false;
                rock1.SetActive(false);
                rock1on = false;
                sheep1.SetActive(false);
                sheep1on = false;
            }
            else if (diamond1on == true)
            {
                diamond1.SetActive(false);
                spotscolour1.SetActive(false);
                diamond1on = false;
            }
        }
        public void showdiamond2()
        {
            if (diamond2on == false)
            {
                diamond2.SetActive(true);
                spotscolour2.SetActive(true);
                diamond2on = true;

                spots2.SetActive(false);
                spots2on = false;
                stripes2.SetActive(false);
                stripes2on = false;
                rainbow2.SetActive(false);
                rainbow2on = false;
                rock2.SetActive(false);
                rock2on = false;
                sheep2.SetActive(false);
                sheep2on = false;
            }
            else if (diamond2on == true)
            {
                diamond2.SetActive(false);
                spotscolour2.SetActive(false);
                diamond2on = false;
            }
        }
        //change diamond colour
        public void diamond1black()
        {
            diamondsblack1.SetActive(true);

            diamondswhite1.SetActive(false);
            diamondsred1.SetActive(false);
            diamondsorange1.SetActive(false);
            diamondsyellow1.SetActive(false);
            diamondsgreen1.SetActive(false);
            diamondsblue1.SetActive(false);
            diamondspurple1.SetActive(false);
        }
        public void diamond1white()
        {
            diamondswhite1.SetActive(true);

            diamondsblack1.SetActive(false);
            diamondsred1.SetActive(false);
            diamondsorange1.SetActive(false);
            diamondsyellow1.SetActive(false);
            diamondsgreen1.SetActive(false);
            diamondsblue1.SetActive(false);
            diamondspurple1.SetActive(false);
        }
        public void diamond1red()
        {
            diamondsred1.SetActive(true);

            diamondswhite1.SetActive(false);
            diamondsblack1.SetActive(false);
            diamondsorange1.SetActive(false);
            diamondsyellow1.SetActive(false);
            diamondsgreen1.SetActive(false);
            diamondsblue1.SetActive(false);
            diamondspurple1.SetActive(false);
        }
        public void diamond1orange()
        {
            diamondsorange1.SetActive(true);

            diamondswhite1.SetActive(false);
            diamondsred1.SetActive(false);
            diamondsblack1.SetActive(false);
            diamondsyellow1.SetActive(false);
            diamondsgreen1.SetActive(false);
            diamondsblue1.SetActive(false);
            diamondspurple1.SetActive(false);
        }
        public void diamond1yellow()
        {
            diamondsyellow1.SetActive(true);

            diamondswhite1.SetActive(false);
            diamondsred1.SetActive(false);
            diamondsorange1.SetActive(false);
            diamondsblack1.SetActive(false);
            diamondsgreen1.SetActive(false);
            diamondsblue1.SetActive(false);
            diamondspurple1.SetActive(false);
        }
        public void diamond1green()
        {
            diamondsgreen1.SetActive(true);

            diamondswhite1.SetActive(false);
            diamondsred1.SetActive(false);
            diamondsorange1.SetActive(false);
            diamondsyellow1.SetActive(false);
            diamondsblack1.SetActive(false);
            diamondsblue1.SetActive(false);
            diamondspurple1.SetActive(false);
        }
        public void diamond1nlue()
        {
            diamondsblue1.SetActive(true);

            diamondswhite1.SetActive(false);
            diamondsred1.SetActive(false);
            diamondsorange1.SetActive(false);
            diamondsyellow1.SetActive(false);
            diamondsgreen1.SetActive(false);
            diamondsblack1.SetActive(false);
            diamondspurple1.SetActive(false);
        }
        public void diamond1purple()
        {
            diamondspurple1.SetActive(true);

            diamondswhite1.SetActive(false);
            diamondsred1.SetActive(false);
            diamondsorange1.SetActive(false);
            diamondsyellow1.SetActive(false);
            diamondsgreen1.SetActive(false);
            diamondsblue1.SetActive(false);
            diamondsblack1.SetActive(false);
        }
        public void diamond2black()
        {
            diamondsblack2.SetActive(true);

            diamondswhite2.SetActive(false);
            diamondsred2.SetActive(false);
            diamondsorange2.SetActive(false);
            diamondsyellow2.SetActive(false);
            diamondsgreen2.SetActive(false);
            diamondsblue2.SetActive(false);
            diamondspurple2.SetActive(false);
        }
        public void diamond2white()
        {
            diamondswhite2.SetActive(true);

            diamondsblack2.SetActive(false);
            diamondsred2.SetActive(false);
            diamondsorange2.SetActive(false);
            diamondsyellow2.SetActive(false);
            diamondsgreen2.SetActive(false);
            diamondsblue2.SetActive(false);
            diamondspurple2.SetActive(false);
        }
        public void diamond2red()
        {
            diamondsred2.SetActive(true);

            diamondswhite2.SetActive(false);
            diamondsblack2.SetActive(false);
            diamondsorange2.SetActive(false);
            diamondsyellow2.SetActive(false);
            diamondsgreen2.SetActive(false);
            diamondsblue2.SetActive(false);
            diamondspurple2.SetActive(false);
        }
        public void diamond2orange()
        {
            diamondsorange2.SetActive(true);

            diamondswhite2.SetActive(false);
            diamondsred2.SetActive(false);
            diamondsblack2.SetActive(false);
            diamondsyellow2.SetActive(false);
            diamondsgreen2.SetActive(false);
            diamondsblue2.SetActive(false);
            diamondspurple2.SetActive(false);
        }
        public void diamond2yellow()
        {
            diamondsyellow2.SetActive(true);

            diamondswhite2.SetActive(false);
            diamondsred2.SetActive(false);
            diamondsorange2.SetActive(false);
            diamondsblack2.SetActive(false);
            diamondsgreen2.SetActive(false);
            diamondsblue2.SetActive(false);
            diamondspurple2.SetActive(false);
        }
        public void diamond2green()
        {
            diamondsgreen2.SetActive(true);

            diamondswhite2.SetActive(false);
            diamondsred2.SetActive(false);
            diamondsorange2.SetActive(false);
            diamondsyellow2.SetActive(false);
            diamondsblack2.SetActive(false);
            diamondsblue2.SetActive(false);
            diamondspurple2.SetActive(false);
        }
        public void diamond2blue()
        {
            diamondsblue2.SetActive(true);

            diamondswhite2.SetActive(false);
            diamondsred2.SetActive(false);
            diamondsorange2.SetActive(false);
            diamondsyellow2.SetActive(false);
            diamondsgreen2.SetActive(false);
            diamondsblack2.SetActive(false);
            diamondspurple2.SetActive(false);
        }
        public void diamond2purple()
        {
            diamondspurple2.SetActive(true);

            diamondswhite2.SetActive(false);
            diamondsred2.SetActive(false);
            diamondsorange2.SetActive(false);
            diamondsyellow2.SetActive(false);
            diamondsgreen2.SetActive(false);
            diamondsblue2.SetActive(false);
            diamondsblack2.SetActive(false);
        }
        //show rainbow
        public void showrainbow1()
        {
            if (rainbow1on == false)
            {
                rainbow1.SetActive(true);
                spotscolour1.SetActive(false);
                rainbow1on = true;

                spots1.SetActive(false);
                spots1on = false;
                stripes1.SetActive(false);
                stripes1on = false;
                diamond1.SetActive(false);
                diamond1on = false;
                rock1.SetActive(false);
                rock1on = false;
                sheep1.SetActive(false);
                sheep1on = false;
            }
            else if (rainbow1on == true)
            {
                rainbow1.SetActive(false);
                rainbow1on = false;
            }
        }
        public void showrainbow2()
        {
            if (rainbow2on == false)
            {
                rainbow2.SetActive(true);
                spotscolour2.SetActive(false);
                rainbow2on = true;

                spots2.SetActive(false);
                spots2on = false;
                stripes2.SetActive(false);
                stripes2on = false;
                diamond2.SetActive(false);
                diamond2on = false;
                rock2.SetActive(false);
                rock2on = false;
                sheep2.SetActive(false);
                sheep2on = false;
            }
            else if (rainbow2on == true)
            {
                rainbow2.SetActive(false);
                rainbow2on = false;
            }
        }
        //show rock
        public void showrock1()
        {
            if (rock1on == false)
            {
                rock1.SetActive(true);
                spotscolour1.SetActive(false);
                rock1on = true;

                spots1.SetActive(false);
                spots1on = false;
                stripes1.SetActive(false);
                stripes1on = false;
                diamond1.SetActive(false);
                diamond1on = false;
                rainbow1.SetActive(false);
                rainbow1on = false;
                sheep1.SetActive(false);
                sheep1on = false;
            }
            else if (rock1on == true)
            {
                rock1.SetActive(false);
                rock1on = false;
            }
        }
        public void showrock2()
        {
            if (rock2on == false)
            {
                rock2.SetActive(true);
                spotscolour2.SetActive(false);
                rock2on = true;

                spots2.SetActive(false);
                spots2on = false;
                stripes2.SetActive(false);
                stripes2on = false;
                diamond2.SetActive(false);
                diamond2on = false;
                rainbow2.SetActive(false);
                rainbow2on = false;
                sheep2.SetActive(false);
                sheep2on = false;
            }
            else if (rock2on == true)
            {
                rock2.SetActive(false);
                rock2on = false;
            }
        }
        //show sheep
        public void showsheep1()
        {
            if (sheep1on == false)
            {
                sheep1.SetActive(true);
                spotscolour1.SetActive(false);
                sheep1on = true;

                spots1.SetActive(false);
                spots1on = false;
                stripes1.SetActive(false);
                stripes1on = false;
                diamond1.SetActive(false);
                diamond1on = false;
                rainbow1.SetActive(false);
                rainbow1on = false;
                rock1.SetActive(false);
                rock1on = false;
            }
            else if (sheep1on == true)
            {
                sheep1.SetActive(false);
                sheep1on = false;
            }
        }
        public void showsheep2()
        {
            if (sheep2on == false)
            {
                sheep2.SetActive(true);
                spotscolour2.SetActive(false);
                sheep2on = true;

                spots2.SetActive(false);
                spots2on = false;
                stripes2.SetActive(false);
                stripes2on = false;
                diamond2.SetActive(false);
                diamond2on = false;
                rainbow2.SetActive(false);
                rainbow2on = false;
                rock2.SetActive(false);
                rock2on = false;
            }
            else if (sheep2on == true)
            {
                sheep2.SetActive(false);
                sheep2on = false;
            }
        }
    }
}
