using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duo_pic
{
    public partial class Form2 : Form
    {
        public static string toform3="";
        PictureBox[] picboxes = new PictureBox[10];
        int time = 100, timenext = 25;
        int[,] pic1 = new int[5,2];
        int[,] pic1_2 = new int[5, 2];
        int[,] pic2 = new int[5, 2];
        int[,] pic2_2 = new int[5, 2];
        int[,] pic3 = new int[5, 2];
        int[,] pic3_2 = new int[5, 2];
        int[,] pic4 = new int[5, 2];
        int[,] pic4_2 = new int[5, 2];
        int[,] pic5 = new int[5, 2];
        int[,] pic5_2 = new int[5, 2];
        int[,] pic6 = new int[5, 2];
        int[,] pic6_2 = new int[5, 2];
        int[,] pic7 = new int[5, 2];
        int[,] pic7_2 = new int[5, 2];
        int[,] pic8 = new int[5, 2];
        int[,] pic8_2 = new int[5, 2];
        int[,] pic9 = new int[5, 2];
        int[,] pic9_2 = new int[5, 2];
        int[,] pic10 = new int[5, 2];
        int[,] pic10_2 = new int[5, 2];
        int[,] pic11 = new int[5, 2];
        int[,] pic11_2 = new int[5, 2];
        int[,] pic12 = new int[5, 2];
        int[,] pic12_2 = new int[5, 2];
        int[,] pic13 = new int[5, 2];
        int[,] pic13_2 = new int[5, 2];
        int[,] pic14 = new int[5, 2];
        int[,] pic14_2 = new int[5, 2];
        int[,] pic15 = new int[5, 2];
        int[,] pic15_2 = new int[5, 2];
        int[,] pic16 = new int[5, 2];
        int[,] pic16_2 = new int[5, 2];
        int[,] pic17 = new int[5, 2];
        int[,] pic17_2 = new int[5, 2];
        int[,] pic18 = new int[5, 2];
        int[,] pic18_2 = new int[5, 2];
        int[,] pic19 = new int[5, 2];
        int[,] pic19_2 = new int[5, 2];
        int[,] pic20 = new int[5, 2];
        int[,] pic20_2 = new int[5, 2];
        int numberstage = 1;
        int score = 0,count=0;
       
        public Form2()
        {
            InitializeComponent();
            ////// p1 //////right
            pic1[0, 0] = 730;//eye
            pic1[0, 1] = 250;//
            pic1[1, 0] = 690;//leaf
            pic1[1, 1] = 130;
            pic1[2, 0] = 748;//neck
            pic1[2, 1] = 350;
            pic1[3, 0] = 645;//monkey
            pic1[3, 1] = 220;
            pic1[4, 0] = 530;//tree
            pic1[4, 1] = 200;
            //left
            pic1_2[0, 0] = 280;//eye
            pic1_2[0, 1] = 250;//
            pic1_2[1, 0] = 241;//leaf
            pic1_2[1, 1] = 125;
            pic1_2[2, 0] = 290;//neck
            pic1_2[2, 1] = 350;
            pic1_2[3, 0] = 193;//monkey
            pic1_2[3, 1] = 217;
            pic1_2[4, 0] = 80;//tree
            pic1_2[4, 1] = 195;
            ////////////////

            ////// p2 //////right
            pic2[0, 0] = 535;//mud
            pic2[0, 1] = 310;
            pic2[1, 0] = 690;//ear
            pic2[1, 1] = 315;
            pic2[2, 0] = 640;//sun
            pic2[2, 1] = 135;
            pic2[3, 0] = 700;//moutain
            pic2[3, 1] = 155;
            pic2[4, 0] = 670;//tree
            pic2[4, 1] = 244;
            //left
            pic2_2[0, 0] = 74;//mud
            pic2_2[0, 1] = 310;
            pic2_2[1, 0] = 240;//ear
            pic2_2[1, 1] = 315;
            pic2_2[2, 0] = 191;//sun
            pic2_2[2, 1] = 135;
            pic2_2[3, 0] = 260;//moutain
            pic2_2[3, 1] = 155;
            pic2_2[4, 0] = 216;//tree
            pic2_2[4, 1] = 244;
            ////////////////

            ////// p3 //////right
            pic3[0, 0] = 560;//foot
            pic3[0, 1] = 335;
            pic3[1, 0] = 643;//pung
            pic3[1, 1] = 338;
            pic3[2, 0] = 579;//hand
            pic3[2, 1] = 213;
            pic3[3, 0] = 695;//nose  
            pic3[3, 1] = 271;
            pic3[4, 0] = 645;//eye
            pic3[4, 1] = 232;
            //left
            pic3_2[0, 0] = 110;//foot
            pic3_2[0, 1] = 335;
            pic3_2[1, 0] = 190;//pung
            pic3_2[1, 1] = 340;
            pic3_2[2, 0] = 134;//hand
            pic3_2[2, 1] = 211;
            pic3_2[3, 0] = 245;//nose
            pic3_2[3, 1] = 271;
            pic3_2[4, 0] = 192;//eye
            pic3_2[4, 1] = 232;
            ////////////////

            ////// p4 //////right
            pic4[0, 0] = 580;//bird
            pic4[0, 1] = 130;
            pic4[1, 0] = 550;//lion
            pic4[1, 1] = 345;
            pic4[2, 0] = 490;//zebra
            pic4[2, 1] = 260;
            pic4[3, 0] = 650;//mount
            pic4[3, 1] = 320;
            pic4[4, 0] = 730;//leg
            pic4[4, 1] = 379;
            //left
            pic4_2[0, 0] = 135;//bird
            pic4_2[0, 1] = 130;
            pic4_2[1, 0] = 93;//lion
            pic4_2[1, 1] = 340;
            pic4_2[2, 0] = 50;//zebra
            pic4_2[2, 1] = 260;
            pic4_2[3, 0] = 195;//mount
            pic4_2[3, 1] = 320;
            pic4_2[4, 0] = 270;//leg
            pic4_2[4, 1] = 379;
            ////////////////

            ////// p5 //////right
            pic5[0, 0] = 530;//eyebrown
            pic5[0, 1] = 150;
            pic5[1, 0] = 525;//foot
            pic5[1, 1] = 310;
            pic5[2, 0] = 652;//e
            pic5[2, 1] = 354;
            pic5[3, 0] = 644;//hair
            pic5[3, 1] = 185;
            pic5[4, 0] = 708;//mouth
            pic5[4, 1] = 180;
            //left
            pic5_2[0, 0] = 78;//eyebrown
            pic5_2[0, 1] = 150;
            pic5_2[1, 0] = 70;//foot
            pic5_2[1, 1] = 310;
            pic5_2[2, 0] = 197;//e
            pic5_2[2, 1] = 354;
            pic5_2[3, 0] = 197;//hair
            pic5_2[3, 1] = 185;
            pic5_2[4, 0] = 255;//mouth
            pic5_2[4, 1] = 180;
            ////////////////

            ////// p6 //////right
            pic6[0, 0] = 578;//ลูกกลมตรงสัญลัก
            pic6[0, 1] = 136;
            pic6[1, 0] = 500;//ดวงจันทร์จรวจแดง
            pic6[1, 1] = 293;
            pic6[2, 0] = 466;//กลมกลมตรงกล้อง
            pic6[2, 1] = 375;
            pic6[3, 0] = 630;//เสื้อ
            pic6[3, 1] = 312;
            pic6[4, 0] = 578;//ถ้วย
            pic6[4, 1] = 392;
            //left
            pic6_2[0, 0] = 130;//ลูกกลมตรงสัญลัก
            pic6_2[0, 1] = 136;
            pic6_2[1, 0] = 52;//ดวงจันทร์จรวจแดง
            pic6_2[1, 1] = 293;
            pic6_2[2, 0] = 18;//กลมกลมตรงกล้อง
            pic6_2[2, 1] = 375;
            pic6_2[3, 0] = 180;//เสื้อ
            pic6_2[3, 1] = 312;
            pic6_2[4, 0] = 128;//ถ้วย
            pic6_2[4, 1] = 392;
            ////////////////

            ////// p7 //////right
            pic7[0, 0] = 653;//จุดแดงขาว
            pic7[0, 1] = 186;
            pic7[1, 0] = 753;//ปากยาวตัวแดง
            pic7[1, 1] = 228;
            pic7[2, 0] = 640;//ตัวเหลืองตรงกลาง
            pic7[2, 1] = 280;
            pic7[3, 0] = 736;//ตาตัวเหลืองอ่อน
            pic7[3, 1] = 344;
            pic7[4, 0] = 588;//จุดใต้ตัวฟ้า
            pic7[4, 1] = 426;
            //left
            pic7_2[0, 0] = 200;//จุดแดงขาว
            pic7_2[0, 1] = 186;
            pic7_2[1, 0] = 303;//ปากยาวตัวแดง
            pic7_2[1, 1] = 228;
            pic7_2[2, 0] = 188;//ตัวเหลืองตรงกลาง
            pic7_2[2, 1] = 280;
            pic7_2[3, 0] = 285;//ตาตัวเหลืองอ่อน
            pic7_2[3, 1] = 344;
            pic7_2[4, 0] = 139;//จุดใต้ตัวฟ้า
            pic7_2[4, 1] = 426;
            ////////////////

            ////// p8 //////right
            pic8[0, 0] = 593;//ขีดตัวหนังสือ
            pic8[0, 1] = 140;
            pic8[1, 0] = 728;//ผม
            pic8[1, 1] = 221;
            pic8[2, 0] = 716;//ผ้าพันคอ
            pic8[2, 1] = 290;
            pic8[3, 0] = 613;//รองเท้า
            pic8[3, 1] = 345;
            pic8[4, 0] = 573;//ฟัน
            pic8[4, 1] = 263;
            //left
            pic8_2[0, 0] = 143;//ขีดตัวหนังสือ
            pic8_2[0, 1] = 140;
            pic8_2[1, 0] = 287;//ผม
            pic8_2[1, 1] = 221;
            pic8_2[2, 0] = 265;//ผ้าพันคอ
            pic8_2[2, 1] = 290;
            pic8_2[3, 0] = 163;//รองเท้า
            pic8_2[3, 1] = 345;
            pic8_2[4, 0] = 123;//ฟัน
            pic8_2[4, 1] = 263;
            ////////////////

            ////// p9 //////right
            pic9[0, 0] = 478;//ลูกห้อยกลมๆ
            pic9[0, 1] = 157;
            pic9[1, 0] = 548;//ลิปบิ้น
            pic9[1, 1] = 125;
            pic9[2, 0] = 634;//ดอกแดงตรงกลาง
            pic9[2, 1] = 130;
            pic9[3, 0] = 478;//ลูกแดงๆมีใบ
            pic9[3, 1] = 230;
            pic9[4, 0] = 635;//เข็มขัด
            pic9[4, 1] = 378;
            //left
            pic9_2[0, 0] = 23;//ลูกห้อยกลมๆ
            pic9_2[0, 1] = 157;
            pic9_2[1, 0] = 97;//ลิปบิ้น
            pic9_2[1, 1] = 125;
            pic9_2[2, 0] = 183;//ดอกแดงตรงกลาง
            pic9_2[2, 1] = 130;
            pic9_2[3, 0] = 26;//ลูกแดงๆมีใบ
            pic9_2[3, 1] = 230;
            pic9_2[4, 0] = 186;//เข็มขัด
            pic9_2[4, 1] = 378;
            ////////////////

            ////// p10 //////right
            pic10[0, 0] = 532;//เมฆ
            pic10[0, 1] = 126;
            pic10[1, 0] = 500;//กระดาษสี
            pic10[1, 1] = 270;
            pic10[2, 0] = 478;//แก้ว
            pic10[2, 1] = 356;
            pic10[3, 0] = 625;//เล็บ
            pic10[3, 1] = 252;
            pic10[4, 0] = 761;//จอเล็ก
            pic10[4, 1] = 309;
            //left
            pic10_2[0, 0] = 87;//เมฆ
            pic10_2[0, 1] = 126;
            pic10_2[1, 0] = 42;//กระดาษสี
            pic10_2[1, 1] = 270;
            pic10_2[2, 0] = 28;//แก้ว
            pic10_2[2, 1] = 356;
            pic10_2[3, 0] = 176;//เล็บ
            pic10_2[3, 1] = 252;
            pic10_2[4, 0] = 305;//จอเล็ก
            pic10_2[4, 1] = 309;
            ////////////////

            ////// p11 //////right
            pic11[0, 0] = 480;//ค้างคาวตัวใหญ่
            pic11[0, 1] = 226;
            pic11[1, 0] = 546;//ค้างคาวตัวเล็ก
            pic11[1, 1] = 155;
            pic11[2, 0] = 753;//กิ่งไม้ข้างขวา
            pic11[2, 1] = 216;
            pic11[3, 0] = 528;//ไม้กางเขนซ้ายมือ
            pic11[3, 1] = 305;
            pic11[4, 0] = 632;//ตัวO
            pic11[4, 1] = 390;
            //left
            pic11_2[0, 0] = 34;//ค้างคาวตัวใหญ่
            pic11_2[0, 1] = 226;
            pic11_2[1, 0] = 100;//ค้างคาวตัวเล็ก
            pic11_2[1, 1] = 155;
            pic11_2[2, 0] = 310;//กิ่งไม้ข้างขวา
            pic11_2[2, 1] = 216;
            pic11_2[3, 0] = 83;//ไม้กางเขนซ้ายมือ
            pic11_2[3, 1] = 305;
            pic11_2[4, 0] = 186;//ตัวO
            pic11_2[4, 1] = 390;
            ////////////////

            ////// p12 //////right
            pic12[0, 0] = 478;//ร่มใหญ่
            pic12[0, 1] = 120;
            pic12[1, 0] = 695;//ไม้แบต
            pic12[1, 1] = 150;
            pic12[2, 0] = 709;//จุดตกใจ
            pic12[2, 1] = 256;
            pic12[3, 0] = 780;//บอลกลม
            pic12[3, 1] = 280;
            pic12[4, 0] = 776;//น้ำ
            pic12[4, 1] = 360;
            //left
            pic12_2[0, 0] = 30;//ร่มใหญ่
            pic12_2[0, 1] = 120;
            pic12_2[1, 0] = 243;//ไม้แบต
            pic12_2[1, 1] = 150;
            pic12_2[2, 0] = 259;//จุดตกใจ
            pic12_2[2, 1] = 256;
            pic12_2[3, 0] = 330;//บอลกลม
            pic12_2[3, 1] = 280;
            pic12_2[4, 0] = 330;//น้ำ
            pic12_2[4, 1] = 360;
            ////////////////

            ////// p13 //////right
            pic13[0, 0] = 757;//number5
            pic13[0, 1] = 133;
            pic13[1, 0] = 502;//number6
            pic13[1, 1] = 200;
            pic13[2, 0] = 629;//number13
            pic13[2, 1] = 263;
            pic13[3, 0] = 500;//number16
            pic13[3, 1] = 326;
            pic13[4, 0] = 694;//number19
            pic13[4, 1] = 328;
            //left
            pic13_2[0, 0] = 308;//number5
            pic13_2[0, 1] = 133;
            pic13_2[1, 0] = 52;//number6
            pic13_2[1, 1] = 200;
            pic13_2[2, 0] = 178;//number13
            pic13_2[2, 1] = 263;
            pic13_2[3, 0] = 50;//number16
            pic13_2[3, 1] = 326;
            pic13_2[4, 0] = 243;//number19
            pic13_2[4, 1] = 328;
            ////////////////

            ////// p14 //////right
            pic14[0, 0] = 704;//cloud
            pic14[0, 1] = 158;
            pic14[1, 0] = 546;//bike
            pic14[1, 1] = 234;
            pic14[2, 0] = 483;//star
            pic14[2, 1] = 310;
            pic14[3, 0] = 568;//window
            pic14[3, 1] = 319;
            pic14[4, 0] = 660;//boat
            pic14[4, 1] = 350;
            //left
            pic14_2[0, 0] = 253;//cloud
            pic14_2[0, 1] = 158;
            pic14_2[1, 0] = 103;//bike
            pic14_2[1, 1] = 234;
            pic14_2[2, 0] = 40;//star
            pic14_2[2, 1] = 310;
            pic14_2[3, 0] = 119;//window
            pic14_2[3, 1] = 319;
            pic14_2[4, 0] = 210;//boat
            pic14_2[4, 1] = 350;
            ////////////////

            ////// p15 //////right
            pic15[0, 0] = 558;//rocket
            pic15[0, 1] = 240;
            pic15[1, 0] = 560;//man
            pic15[1, 1] = 374;
            pic15[2, 0] = 740;//rockred
            pic15[2, 1] = 285;
            pic15[3, 0] = 685;//star
            pic15[3, 1] = 268;
            pic15[4, 0] = 789;//starsmall
            pic15[4, 1] = 240;

            //left
            pic15_2[0, 0] = 117;//rocket
            pic15_2[0, 1] = 240;
            pic15_2[1, 0] = 113;//man
            pic15_2[1, 1] = 374;
            pic15_2[2, 0] = 287;//rockred
            pic15_2[2, 1] = 285;
            pic15_2[3, 0] = 230;//star
            pic15_2[3, 1] = 268;
            pic15_2[4, 0] = 334;//starsmall
            pic15_2[4, 1] = 240;
            ////////////////

            ////// p16 //////right
            pic16[0, 0] = 650;//star
            pic16[0, 1] = 150;
            pic16[1, 0] = 570;//circle blue
            pic16[1, 1] = 140;
            pic16[2, 0] = 590;//car on book
            pic16[2, 1] = 359;
            pic16[3, 0] = 676;//tooth girl
            pic16[3, 1] = 280;
            pic16[4, 0] = 570;//mouth boy
            pic16[4, 1] = 280;
            //left
            pic16_2[0, 0] = 210;//star
            pic16_2[0, 1] = 150;
            pic16_2[1, 0] = 120;//circle blue
            pic16_2[1, 1] = 140;
            pic16_2[2, 0] = 130;//car on book
            pic16_2[2, 1] = 359;
            pic16_2[3, 0] = 223;//tooth girl
            pic16_2[3, 1] = 280;
            pic16_2[4, 0] = 121;//mouth boy
            pic16_2[4, 1] = 280;
            ////////////////

            ////// p17 //////right
            pic17[0, 0] = 795;//moon
            pic17[0, 1] = 223;
            pic17[1, 0] = 735;//heart
            pic17[1, 1] = 260;
            pic17[2, 0] = 765;//murmaid
            pic17[2, 1] = 320;
            pic17[3, 0] = 704;//boat
            pic17[3, 1] = 362;
            pic17[4, 0] = 649;//house
            pic17[4, 1] = 419;
            //left
            pic17_2[0, 0] = 348;//moon
            pic17_2[0, 1] = 223;
            pic17_2[1, 0] = 284;//heart
            pic17_2[1, 1] = 260;
            pic17_2[2, 0] = 316;//murmaid
            pic17_2[2, 1] = 320;
            pic17_2[3, 0] = 250;//boat
            pic17_2[3, 1] = 362;
            pic17_2[4, 0] = 204;//house
            pic17_2[4, 1] = 419;
            ////////////////

            ////// p18 //////right
            pic18[0, 0] = 680;//triangle
            pic18[0, 1] = 160;
            pic18[1, 0] = 560;//mouth woman
            pic18[1, 1] = 180;
            pic18[2, 0] = 559;//เข็มขัดผญ.
            pic18[2, 1] = 265;
            pic18[3, 0] = 474;//cloud  
            pic18[3, 1] = 310;
            pic18[4, 0] = 553;//shoe
            pic18[4, 1] = 351;
            //left
            pic18_2[0, 0] = 230;//traiangle
            pic18_2[0, 1] = 160;
            pic18_2[1, 0] = 110;//mouth woman
            pic18_2[1, 1] = 180;
            pic18_2[2, 0] = 109;//เข็มขัดผญ.
            pic18_2[2, 1] = 265;
            pic18_2[3, 0] = 23;//cloud
            pic18_2[3, 1] = 310;
            pic18_2[4, 0] = 104;//shoe
            pic18_2[4, 1] = 352;
            ////////////////

            ////// p19 //////right
            pic19[0, 0] = 603;//star
            pic19[0, 1] = 140;
            pic19[1, 0] = 610;//window
            pic19[1, 1] = 250;
            pic19[2, 0] = 529;//bird
            pic19[2, 1] = 279;
            pic19[3, 0] = 684;//circle
            pic19[3, 1] = 315;
            pic19[4, 0] = 630;//bookc
            pic19[4, 1] = 400;
            //left
            pic19_2[0, 0] = 153;//star
            pic19_2[0, 1] = 140;
            pic19_2[1, 0] = 160;//window
            pic19_2[1, 1] = 250;
            pic19_2[2, 0] = 80;//bird
            pic19_2[2, 1] = 279;
            pic19_2[3, 0] = 234;//circle
            pic19_2[3, 1] = 315;
            pic19_2[4, 0] = 176;//bookc
            pic19_2[4, 1] = 400;
            ////////////////

            ////// p20 //////right
            pic20[0, 0] = 519;//bottle
            pic20[0, 1] = 234;
            pic20[1, 0] = 677;//sign
            pic20[1, 1] = 270;
            pic20[2, 0] = 615;//red circle
            pic20[2, 1] = 310;
            pic20[3, 0] = 560;//tomato
            pic20[3, 1] = 362;
            pic20[4, 0] = 710;//carot
            pic20[4, 1] = 368;
            //left
            pic20_2[0, 0] = 70;//bottle
            pic20_2[0, 1] = 234;
            pic20_2[1, 0] = 225;//sign
            pic20_2[1, 1] = 270;
            pic20_2[2, 0] = 165;//red circle
            pic20_2[2, 1] = 310;
            pic20_2[3, 0] = 110;//tomato
            pic20_2[3, 1] = 362;
            pic20_2[4, 0] = 256;//carot
            pic20_2[4, 1] = 368;
            ////////////////

            createpicbox();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time--;
                pro_time.Value = time;
            }
            else if (pro_time.Value==0)
            {
                timer1.Enabled = false;
                endgame();
            }
        }

        private void btn_resume_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void PictureBoxes_Click(object sender, EventArgs e)
        {
            score++;
            count++; 
            PictureBox p = (PictureBox)sender;
            p.Image = imageList1.Images[0];
            p.Enabled = false;
            la_score.Text = score.ToString();
           // timer1.Stop();  
            for (int n = 0; n < 5; n++)
            {
                if (picboxes[n] == (PictureBox)sender)
                {
                    picboxes[5 + n].Image = imageList1.Images[0];
                    picboxes[5 + n].Enabled = false;
                }

            }
            for (int n = 5; n < 10  ; n++)
            {
                if (picboxes[n] == (PictureBox)sender)
                {
                    picboxes[n-5].Image = imageList1.Images[0];
                    picboxes[n-5].Enabled = false;
                }

            }
                if (count == 5)
                {
                    timer_next.Enabled = true;

                }
        }
        private void nextstage(int count, PictureBox[] picboxes)
        {
            timer_next.Enabled = false;
            timenext = 25;
            numberstage++;
            for (byte i = 0; i < 10; i++)
            {
                picboxes[i].Dispose();
            }
            if (numberstage == 2)
            {
                this.BackgroundImage = Properties.Resources.p2;               
            }
            else if (numberstage == 3)
            {
                this.BackgroundImage = Properties.Resources.p3;
            }
            else if (numberstage == 4)
            {
                this.BackgroundImage = Properties.Resources.p4;
            }
            else if (numberstage == 5)
            {
                this.BackgroundImage = Properties.Resources.p5;
            }
            else if (numberstage == 6)
            {
                this.BackgroundImage = Properties.Resources.p6;
            }
            else if (numberstage == 7)
            {
                this.BackgroundImage = Properties.Resources.p7;
            }
            else if (numberstage == 8)
            {
                this.BackgroundImage = Properties.Resources.p8;
            }
            else if (numberstage == 9)
            {
                this.BackgroundImage = Properties.Resources.p9;
            }
            else if (numberstage == 10)
            {
                this.BackgroundImage = Properties.Resources.p10;
            }
            else if (numberstage == 11)
            {
                this.BackgroundImage = Properties.Resources.p11;
            }
            else if (numberstage == 12)
            {
                this.BackgroundImage = Properties.Resources.p12;
            }
            else if (numberstage == 13)
            {
                this.BackgroundImage = Properties.Resources.p13;
            }
            else if (numberstage == 14)
            {
                this.BackgroundImage = Properties.Resources.p14;
            }
            else if (numberstage == 15)
            {
                this.BackgroundImage = Properties.Resources.p15;
            }
            else if (numberstage == 16)
            {
                this.BackgroundImage = Properties.Resources.p16;
            }
            else if (numberstage == 17)
            {
                this.BackgroundImage = Properties.Resources.p17;
            }
            else if (numberstage == 18)
            {
                this.BackgroundImage = Properties.Resources.p18;
            }
            else if (numberstage == 19)
            {
                this.BackgroundImage = Properties.Resources.p19;
            }
            else if (numberstage == 20)
            {
                this.BackgroundImage = Properties.Resources.p20;
            }
            createpicbox();
            
        }

        private void timer_next_Tick(object sender, EventArgs e)
        {
            timenext--;
            if (timenext == 0)
            {
                nextstage(count, picboxes);
                count = 0;
            }
        }
        private void createpicbox()
        {
            switch (numberstage)
            {
                case 1:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic1[0, 0], pic1[0, 1]);
                                
                                break;
                            case 1: picboxes[num].Location = new Point(pic1[1, 0], pic1[1, 1]);
                                
                                break;
                            case 2: picboxes[num].Location = new Point(pic1[2, 0], pic1[2, 1]);
                                
                                break;
                            case 3: picboxes[num].Location = new Point(pic1[3, 0], pic1[3, 1]);
                                
                                break;
                            case 4: picboxes[num].Location = new Point(pic1[4, 0], pic1[4, 1]);
                                
                                break;
                                /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic1_2[0, 0], pic1_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic1_2[1, 0], pic1_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic1_2[2, 0], pic1_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic1_2[3, 0], pic1_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic1_2[4, 0], pic1_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic1_2[0, 0], pic1_2[0, 1]);
                                break;
                        }
                        picboxes[num].Width = 90;
                        picboxes[num].Height = 90;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 2:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic2[0, 0], pic2[0, 1]);
                                break;
                            case 1: picboxes[num].Location = new Point(pic2[1, 0], pic2[1, 1]);
                                break;
                            case 2: picboxes[num].Location = new Point(pic2[2, 0], pic2[2, 1]);
                                break;
                            case 3: picboxes[num].Location = new Point(pic2[3, 0], pic2[3, 1]);
                                break;
                            case 4: picboxes[num].Location = new Point(pic2[4, 0], pic2[4, 1]);
                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic2_2[0, 0], pic2_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic2_2[1, 0], pic2_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic2_2[2, 0], pic2_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic2_2[3, 0], pic2_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic2_2[4, 0], pic2_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic2[0, 0], pic2[0, 1]);
                                break;
                        }
                        
                        picboxes[num].SizeMode = PictureBoxSizeMode.StretchImage;
                        picboxes[num].Width = 60;
                        picboxes[num].Height = 60;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 3:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic3[0, 0], pic3[0, 1]);
                                break;
                            case 1: picboxes[num].Location = new Point(pic3[1, 0], pic3[1, 1]);
                                break;
                            case 2: picboxes[num].Location = new Point(pic3[2, 0], pic3[2, 1]);
                                break;
                            case 3: picboxes[num].Location = new Point(pic3[3, 0], pic3[3, 1]);
                                break;
                            case 4: picboxes[num].Location = new Point(pic3[4, 0], pic3[4, 1]);
                                break;
                                ///////////////////////
                            case 5: picboxes[num].Location = new Point(pic3_2[0, 0], pic3_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic3_2[1, 0], pic3_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic3_2[2, 0], pic3_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic3_2[3, 0], pic3_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic3_2[4, 0], pic3_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic3[0, 0], pic3[0, 1]);
                                break;
                        }
                        picboxes[num].SizeMode = PictureBoxSizeMode.StretchImage;
                        picboxes[num].Width = 60;
                        picboxes[num].Height = 60;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 4:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic4[0, 0], pic4[0, 1]);
                                break;
                            case 1: picboxes[num].Location = new Point(pic4[1, 0], pic4[1, 1]);
                                break;
                            case 2: picboxes[num].Location = new Point(pic4[2, 0], pic4[2, 1]);
                                break;
                            case 3: picboxes[num].Location = new Point(pic4[3, 0], pic4[3, 1]);
                                break;
                            case 4: picboxes[num].Location = new Point(pic4[4, 0], pic4[4, 1]);
                                break;
                            ///////////////////////
                            case 5: picboxes[num].Location = new Point(pic4_2[0, 0], pic4_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic4_2[1, 0], pic4_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic4_2[2, 0], pic4_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic4_2[3, 0], pic4_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic4_2[4, 0], pic4_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic4[0, 0], pic4[0, 1]);
                                break;
                        }
                        picboxes[num].Width = 90;
                        picboxes[num].Height = 90;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 5:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic5[0, 0], pic5[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic5[1, 0], pic5[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic5[2, 0], pic5[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic5[3, 0], pic5[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic5[4, 0], pic5[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic5_2[0, 0], pic5_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic5_2[1, 0], pic5_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic5_2[2, 0], pic5_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic5_2[3, 0], pic5_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic5_2[4, 0], pic5_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic5_2[0, 0], pic5_2[0, 1]);
                                break;
                        }
                        picboxes[num].Width = 90;
                        picboxes[num].Height = 90;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 6:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic6[0, 0], pic6[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic6[1, 0], pic6[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic6[2, 0], pic6[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic6[3, 0], pic6[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic6[4, 0], pic6[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic6_2[0, 0], pic6_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic6_2[1, 0], pic6_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic6_2[2, 0], pic6_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic6_2[3, 0], pic6_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic6_2[4, 0], pic6_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic6_2[0, 0], pic6_2[0, 1]);
                                break;
                        }
                        picboxes[num].Width = 90;
                        picboxes[num].Height = 90;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 7:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic7[0, 0], pic7[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic7[1, 0], pic7[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic7[2, 0], pic7[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic7[3, 0], pic7[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic7[4, 0], pic7[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic7_2[0, 0], pic7_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic7_2[1, 0], pic7_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic7_2[2, 0], pic7_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic7_2[3, 0], pic7_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic7_2[4, 0], pic7_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic7_2[0, 0], pic7_2[0, 1]);
                                break;
                        }
                        picboxes[num].Width = 90;
                        picboxes[num].Height = 90;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 8:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic8[0, 0], pic8[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic8[1, 0], pic8[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic8[2, 0], pic8[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic8[3, 0], pic8[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic8[4, 0], pic8[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic8_2[0, 0], pic8_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic8_2[1, 0], pic8_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic8_2[2, 0], pic8_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic8_2[3, 0], pic8_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic8_2[4, 0], pic8_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic8_2[0, 0], pic8_2[0, 1]);
                                break;
                        }
                        picboxes[num].SizeMode = PictureBoxSizeMode.StretchImage;
                        picboxes[num].Width = 70;
                        picboxes[num].Height = 70;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 9:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic9[0, 0], pic9[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic9[1, 0], pic9[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic9[2, 0], pic9[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic9[3, 0], pic9[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic9[4, 0], pic9[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic9_2[0, 0], pic9_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic9_2[1, 0], pic9_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic9_2[2, 0], pic9_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic9_2[3, 0], pic9_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic9_2[4, 0], pic9_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic9_2[0, 0], pic9_2[0, 1]);
                                break;
                        }
                        picboxes[num].SizeMode = PictureBoxSizeMode.StretchImage;
                        picboxes[num].Width = 80;
                        picboxes[num].Height = 80;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 10:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic10[0, 0], pic10[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic10[1, 0], pic10[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic10[2, 0], pic10[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic10[3, 0], pic10[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic10[4, 0], pic10[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic10_2[0, 0], pic10_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic10_2[1, 0], pic10_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic10_2[2, 0], pic10_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic10_2[3, 0], pic10_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic10_2[4, 0], pic10_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic10_2[0, 0], pic10_2[0, 1]);
                                break;
                        }
                        picboxes[num].Width = 90;
                        picboxes[num].Height = 90;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 11:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic11[0, 0], pic11[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic11[1, 0], pic11[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic11[2, 0], pic11[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic11[3, 0], pic11[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic11[4, 0], pic11[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic11_2[0, 0], pic11_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic11_2[1, 0], pic11_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic11_2[2, 0], pic11_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic11_2[3, 0], pic11_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic11_2[4, 0], pic11_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic11_2[0, 0], pic11_2[0, 1]);
                                break;
                        }
                        picboxes[num].Width = 90;
                        picboxes[num].Height = 90;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 12:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic12[0, 0], pic12[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic12[1, 0], pic12[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic12[2, 0], pic12[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic12[3, 0], pic12[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic12[4, 0], pic12[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic12_2[0, 0], pic12_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic12_2[1, 0], pic12_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic12_2[2, 0], pic12_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic12_2[3, 0], pic12_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic12_2[4, 0], pic12_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic12_2[0, 0], pic12_2[0, 1]);
                                break;
                        }
                        picboxes[num].SizeMode = PictureBoxSizeMode.StretchImage;
                        picboxes[num].Width = 80;
                        picboxes[num].Height = 80;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 13:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic13[0, 0], pic13[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic13[1, 0], pic13[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic13[2, 0], pic13[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic13[3, 0], pic13[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic13[4, 0], pic13[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic13_2[0, 0], pic13_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic13_2[1, 0], pic13_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic13_2[2, 0], pic13_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic13_2[3, 0], pic13_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic13_2[4, 0], pic13_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic13_2[0, 0], pic13_2[0, 1]);
                                break;
                        }
                        picboxes[num].Width = 90;
                        picboxes[num].Height = 90;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 14:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic14[0, 0], pic14[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic14[1, 0], pic14[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic14[2, 0], pic14[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic14[3, 0], pic14[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic14[4, 0], pic14[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic14_2[0, 0], pic14_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic14_2[1, 0], pic14_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic14_2[2, 0], pic14_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic14_2[3, 0], pic14_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic14_2[4, 0], pic14_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic14_2[0, 0], pic14_2[0, 1]);
                                break;
                        }
                        picboxes[num].Width = 90;
                        picboxes[num].Height = 90;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 15:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic15[0, 0], pic15[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic15[1, 0], pic15[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic15[2, 0], pic15[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic15[3, 0], pic15[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic15[4, 0], pic15[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic15_2[0, 0], pic15_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic15_2[1, 0], pic15_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic15_2[2, 0], pic15_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic15_2[3, 0], pic15_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic15_2[4, 0], pic15_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic15_2[0, 0], pic15_2[0, 1]);
                                break;
                        }
                        picboxes[num].SizeMode = PictureBoxSizeMode.StretchImage;
                        picboxes[num].Width = 60;
                        picboxes[num].Height = 60;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 16:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic16[0, 0], pic16[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic16[1, 0], pic16[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic16[2, 0], pic16[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic16[3, 0], pic16[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic16[4, 0], pic16[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic16_2[0, 0], pic16_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic16_2[1, 0], pic16_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic16_2[2, 0], pic16_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic16_2[3, 0], pic16_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic16_2[4, 0], pic16_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic16_2[0, 0], pic16_2[0, 1]);
                                break;
                        }
                        picboxes[num].Width = 90;
                        picboxes[num].Height = 90;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 17:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic17[0, 0], pic17[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic17[1, 0], pic17[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic17[2, 0], pic17[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic17[3, 0], pic17[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic17[4, 0], pic17[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic17_2[0, 0], pic17_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic17_2[1, 0], pic17_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic17_2[2, 0], pic17_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic17_2[3, 0], pic17_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic17_2[4, 0], pic17_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic17_2[0, 0], pic17_2[0, 1]);
                                break;
                        }
                        picboxes[num].SizeMode = PictureBoxSizeMode.StretchImage;
                        picboxes[num].Width = 70;
                        picboxes[num].Height = 70;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 18:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic18[0, 0], pic18[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic18[1, 0], pic18[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic18[2, 0], pic18[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic18[3, 0], pic18[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic18[4, 0], pic18[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic18_2[0, 0], pic18_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic18_2[1, 0], pic18_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic18_2[2, 0], pic18_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic18_2[3, 0], pic18_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic18_2[4, 0], pic18_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic18_2[0, 0], pic18_2[0, 1]);
                                break;
                        }
                        picboxes[num].Width = 90;
                        picboxes[num].Height = 90;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 19:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic19[0, 0], pic19[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic19[1, 0], pic19[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic19[2, 0], pic19[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic19[3, 0], pic19[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic19[4, 0], pic19[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic19_2[0, 0], pic19_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic19_2[1, 0], pic19_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic19_2[2, 0], pic19_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic19_2[3, 0], pic19_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic19_2[4, 0], pic19_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic19_2[0, 0], pic19_2[0, 1]);
                                break;
                        }
                        picboxes[num].Width = 90;
                        picboxes[num].Height = 90;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 20:
                    for (byte num = 0; num < 10; num++)
                    {
                        picboxes[num] = new PictureBox();
                        switch (num)
                        {
                            case 0: picboxes[num].Location = new Point(pic20[0, 0], pic20[0, 1]);

                                break;
                            case 1: picboxes[num].Location = new Point(pic20[1, 0], pic20[1, 1]);

                                break;
                            case 2: picboxes[num].Location = new Point(pic20[2, 0], pic20[2, 1]);

                                break;
                            case 3: picboxes[num].Location = new Point(pic20[3, 0], pic20[3, 1]);

                                break;
                            case 4: picboxes[num].Location = new Point(pic20[4, 0], pic20[4, 1]);

                                break;
                            /////////////////////////////
                            case 5: picboxes[num].Location = new Point(pic20_2[0, 0], pic20_2[0, 1]);
                                break;
                            case 6: picboxes[num].Location = new Point(pic20_2[1, 0], pic20_2[1, 1]);
                                break;
                            case 7: picboxes[num].Location = new Point(pic20_2[2, 0], pic20_2[2, 1]);
                                break;
                            case 8: picboxes[num].Location = new Point(pic20_2[3, 0], pic20_2[3, 1]);
                                break;
                            case 9: picboxes[num].Location = new Point(pic20_2[4, 0], pic20_2[4, 1]);
                                break;
                            default: picboxes[num].Location = new Point(pic20_2[0, 0], pic20_2[0, 1]);
                                break;
                        }
                        picboxes[num].SizeMode = PictureBoxSizeMode.StretchImage;
                        picboxes[num].Width = 70;
                        picboxes[num].Height = 70;
                        picboxes[num].BackColor = Color.Transparent;
                        Controls.Add(picboxes[num]);
                        picboxes[num].BringToFront();
                        picboxes[num].Click += new System.EventHandler(PictureBoxes_Click);
                    }
                    break;
                case 21: endgame();
                    break;
                default: endgame();
                    break;
            }
            
        }
        public void endgame()
        {
            //MessageBox.Show("Game Over");
            toform3 = score.ToString();
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }
    }
}