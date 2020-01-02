using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Reddit
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);

        public class Win32
        {
            [DllImport("User32.Dll")]
            public static extern long SetCursorPos(int x, int y);

            [DllImport("User32.Dll")]
            public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

            [StructLayout(LayoutKind.Sequential)]
            public struct POINT
            {
                public int x;
                public int y;
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        List<string> userNames = new List<string> { };
        string nextUsername = "";
        string nextPassword = "ploolo11";

        int ind = 0;

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        public Form1()
        {
            InitializeComponent();

            foreach (string line in System.IO.File.ReadLines(@"C:\Users\stein\source\repos\Reddit\Reddit\bin\Debug\AvaUsernames.txt"))
            {
                userNames.Add(line);
            }

            userNames = userNames.Distinct().ToList();

            nextUsername = userNames[ind];

            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((((ushort)GetKeyState(0x14)) & 0xffff) != 0){
                richTextBox1.Text += "{" + Cursor.Position.X + ", " + Cursor.Position.Y + "}, "; 
            }
        }

        int[][] m1 = new int[][] { new int[]{ 2672, 537 }, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 537}, new int[]{2672, 540}, new int[]{2673, 544}, new int[]{2674, 546}, new int[]{2676, 552}, new int[]{2677, 553}, new int[]{2679, 556}, new int[]{2681, 559}, new int[]{2682, 561}, new int[]{2683, 564}, new int[]{2685, 565}, new int[]{2687, 569}, new int[]{2689, 573}, new int[]{2691, 576}, new int[]{2691, 578}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 580}, new int[]{2693, 581}, new int[]{2695, 583}, new int[]{2695, 584}, new int[]{2696, 584}, new int[]{2696, 585}, new int[]{2697, 585}, new int[]{2697, 586}, new int[]{2698, 588}, new int[]{2699, 589}, new int[]{2700, 591}, new int[]{2700, 592}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2702, 593}, new int[]{2703, 591}, new int[]{2704, 590}, new int[]{2706, 588}, new int[]{2707, 587}, new int[]{2707, 585}, new int[]{2708, 585}, new int[]{2708, 584}, new int[]{2708, 583}, new int[]{2709, 581}, new int[]{2710, 579}, new int[]{2710, 578}, new int[]{2710, 574}, new int[]{2710, 572}, new int[]{2710, 570}, new int[]{2710, 568}, new int[]{2710, 568}, new int[]{2710, 567}, new int[]{2710, 566}, new int[]{2710, 565}, new int[]{2710, 563}, new int[]{2709, 560}, new int[]{2708, 558}, new int[]{2706, 554}, new int[]{2704, 548}, new int[]{2704, 547}, new int[]{2702, 543}, new int[]{2701, 541}, new int[]{2700, 540}, new int[]{2699, 537}, new int[]{2698, 536}, new int[]{2697, 534}, new int[]{2697, 533}, new int[]{2696, 531}, new int[]{2694, 529}, new int[]{2693, 528}, new int[]{2691, 525}, new int[]{2688, 524}, new int[]{2686, 522}, new int[]{2682, 521}, new int[]{2678, 518}, new int[]{2674, 516}, new int[]{2670, 514}, new int[]{2664, 510}, new int[]{2661, 508}, new int[]{2657, 505}, new int[]{2654, 504}, new int[]{2647, 499}, new int[]{2643, 498}, new int[]{2641, 497}, new int[]{2637, 494}, new int[]{2635, 494}, new int[]{2632, 492}, new int[]{2630, 491}, new int[]{2629, 490}, new int[]{2628, 490}, new int[]{2628, 489}, new int[]{2627, 489}, new int[]{2626, 487}, new int[]{2626, 486}, new int[]{2623, 484}, new int[]{2622, 483}, new int[]{2622, 482}, new int[]{2619, 482}, new int[]{2618, 481}, new int[]{2617, 480}, new int[]{2614, 479}, new int[]{2612, 478}, new int[]{2611, 478}, new int[]{2609, 477}, new int[]{2608, 476}, new int[]{2606, 475}, new int[]{2605, 474}, new int[]{2603, 474}, new int[]{2602, 473}, new int[]{2599, 471}, new int[]{2596, 470}, new int[]{2594, 468}, new int[]{2591, 467}, new int[]{2590, 466}, new int[]{2588, 465}, new int[]{2588, 465}, new int[]{2586, 465}, new int[]{2585, 464}, new int[]{2585, 464}, new int[]{2583, 463}, new int[]{2581, 462}, new int[]{2580, 462}, new int[]{2578, 461}, new int[]{2578, 460}, new int[]{2577, 460}, new int[]{2577, 460}, new int[]{2576, 460}, new int[]{2576, 460}, new int[]{2575, 460}, new int[]{2573, 460}, new int[]{2573, 460}, new int[]{2570, 459}, new int[]{2569, 459}, new int[]{2565, 459}, new int[]{2564, 459}, new int[]{2562, 459}, new int[]{2561, 459}, new int[]{2560, 459}, new int[]{2559, 459}, new int[]{2559, 459}, new int[]{2558, 459}, new int[]{2558, 459}, new int[]{2556, 459}, new int[]{2555, 459}, new int[]{2555, 459}, new int[]{2555, 459}};
        int[][] m2 = new int[][] { new int[]{ 2550, 467 }, new int[]{ 2550, 467 }, new int[]{ 2550, 466 }, new int[]{ 2550, 465 }, new int[]{ 2550, 464 }, new int[]{ 2550, 463 }, new int[]{ 2550, 462 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 461 }, new int[]{ 2550, 462 }, new int[]{ 2549, 463 }, new int[]{ 2549, 464 }, new int[]{ 2549, 466 }, new int[]{ 2551, 466 }, new int[]{ 2551, 468 }, new int[]{ 2552, 468 }, new int[]{ 2552, 470 }, new int[]{ 2553, 470 }, new int[]{ 2556, 473 }, new int[]{ 2557, 476 }, new int[]{ 2560, 482 }, new int[]{ 2561, 485 }, new int[]{ 2563, 490 }, new int[]{ 2565, 496 }, new int[]{ 2566, 498 }, new int[]{ 2567, 503 }, new int[]{ 2567, 507 }, new int[]{ 2568, 511 }, new int[]{ 2569, 513 }, new int[]{ 2571, 517 }, new int[]{ 2572, 520 }, new int[]{ 2573, 524 }, new int[]{ 2574, 524 }, new int[]{ 2575, 527 }, new int[]{ 2576, 530 }, new int[]{ 2577, 531 }, new int[]{ 2577, 533 }, new int[]{ 2577, 534 }, new int[]{ 2578, 536 }, new int[]{ 2578, 536 }, new int[]{ 2578, 537 }, new int[]{ 2578, 537 }, new int[]{ 2578, 538 }, new int[]{ 2578, 539 }, new int[]{ 2578, 540 }, new int[]{ 2578, 541 }, new int[]{ 2578, 542 }, new int[]{ 2577, 544 }, new int[]{ 2577, 544 }, new int[]{ 2576, 545 }, new int[]{ 2575, 546 }, new int[]{ 2575, 546 }, new int[]{ 2574, 547 }, new int[]{ 2573, 547 }, new int[]{ 2573, 547 }, new int[]{ 2573, 547 }, new int[]{ 2572, 548 }, new int[]{ 2571, 548 }, new int[]{ 2571, 549 }, new int[]{ 2571, 550 }, new int[]{ 2570, 550 }, new int[]{ 2570, 550 }, new int[]{ 2569, 550 }, new int[]{ 2569, 550 }, new int[]{ 2569, 551 }, new int[]{ 2569, 551 }, new int[]{ 2568, 551 }, new int[]{ 2568, 551 }, new int[]{ 2567, 553 }, new int[]{ 2567, 553 }, new int[]{ 2567, 553 }, new int[]{ 2567, 553 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 554 }, new int[]{ 2566, 555 }, new int[]{ 2566, 557 }, new int[]{ 2566, 558 }, new int[]{ 2566, 558 }, new int[]{ 2566, 559 }, new int[]{ 2566, 559 }, new int[]{ 2566, 560 }, new int[]{ 2566, 560 }, new int[]{ 2566, 561 }, new int[]{ 2566, 561 }, new int[]{ 2566, 561 }, new int[]{ 2566, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 561 }, new int[]{ 2565, 560 }, new int[]{ 2565, 559 }, new int[]{ 2565, 558 }, new int[]{ 2565, 556 }, new int[]{ 2565, 555 }, new int[]{ 2565, 555 }, new int[]{ 2565, 555 }, new int[]{ 2565, 555 }, new int[]{ 2565, 555 }, new int[]{ 2565, 555 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 554 }, new int[]{ 2565, 552 }, new int[]{ 2563, 548 }, new int[]{ 2560, 543 }, new int[] { 2555, 540 }, new int[] { 2550, 535 }, new int[] { 2547, 530 } };
        int[][] m3 = new int[][] { new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 556 }, new int[] { 2590, 558 }, new int[] { 2590, 558 }, new int[] { 2590, 559 }, new int[] { 2590, 560 }, new int[] { 2590, 561 }, new int[] { 2590, 562 }, new int[] { 2590, 562 }, new int[] { 2590, 563 }, new int[] { 2590, 565 }, new int[] { 2590, 565 }, new int[] { 2590, 567 }, new int[] { 2590, 568 }, new int[] { 2590, 568 }, new int[] { 2590, 568 }, new int[] { 2590, 570 }, new int[] { 2590, 571 }, new int[] { 2590, 572 }, new int[] { 2589, 572 }, new int[] { 2589, 573 }, new int[] { 2589, 574 }, new int[] { 2589, 576 }, new int[] { 2589, 576 }, new int[] { 2588, 578 }, new int[] { 2588, 580 }, new int[] { 2587, 581 }, new int[] { 2585, 585 }, new int[] { 2585, 587 }, new int[] { 2582, 591 }, new int[] { 2580, 593 }, new int[] { 2579, 597 }, new int[] { 2577, 601 }, new int[] { 2575, 604 }, new int[] { 2572, 607 }, new int[] { 2569, 611 }, new int[] { 2568, 613 }, new int[] { 2566, 615 }, new int[] { 2564, 618 }, new int[] { 2563, 620 }, new int[] { 2562, 623 }, new int[] { 2561, 624 }, new int[] { 2561, 626 }, new int[] { 2560, 627 }, new int[] { 2560, 628 }, new int[] { 2560, 630 }, new int[] { 2560, 631 }, new int[] { 2560, 633 }, new int[] { 2560, 635 }, new int[] { 2560, 635 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 636 }, new int[] { 2560, 635 }, new int[] { 2562, 633 }, new int[] { 2562, 632 }, new int[] { 2562, 631 }, new int[] { 2562, 631 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 }, new int[] { 2562, 630 } };
        int[][] m4 = new int[][] { new int[] { 2556, 628 }, new int[] { 2556, 628 }, new int[] { 2556, 628 }, new int[] { 2556, 628 }, new int[] { 2556, 628 }, new int[] { 2556, 628 }, new int[] { 2556, 628 }, new int[] { 2556, 628 }, new int[] { 2556, 628 }, new int[] { 2556, 628 }, new int[] { 2556, 628 }, new int[] { 2556, 628 }, new int[] { 2556, 628 }, new int[] { 2556, 628 }, new int[] { 2557, 630 }, new int[] { 2563, 633 }, new int[] { 2566, 635 }, new int[] { 2579, 642 }, new int[] { 2586, 645 }, new int[] { 2598, 650 }, new int[] { 2608, 653 }, new int[] { 2621, 657 }, new int[] { 2629, 660 }, new int[] { 2636, 663 }, new int[] { 2651, 666 }, new int[] { 2652, 666 }, new int[] { 2660, 669 }, new int[] { 2669, 671 }, new int[] { 2677, 674 }, new int[] { 2683, 675 }, new int[] { 2695, 679 }, new int[] { 2708, 684 }, new int[] { 2719, 688 }, new int[] { 2730, 692 }, new int[] { 2739, 696 }, new int[] { 2754, 702 }, new int[] { 2776, 709 }, new int[] { 2784, 712 }, new int[] { 2799, 717 }, new int[] { 2815, 722 }, new int[] { 2824, 725 }, new int[] { 2834, 729 }, new int[] { 2843, 733 }, new int[] { 2853, 737 }, new int[] { 2863, 741 }, new int[] { 2874, 745 }, new int[] { 2886, 750 }, new int[] { 2900, 755 }, new int[] { 2906, 757 }, new int[] { 2915, 760 }, new int[] { 2932, 766 }, new int[] { 2936, 768 }, new int[] { 2952, 775 }, new int[] { 2960, 778 }, new int[] { 2972, 782 }, new int[] { 2978, 784 }, new int[] { 2986, 786 }, new int[] { 2990, 788 }, new int[] { 2996, 791 }, new int[] { 3004, 794 }, new int[] { 3014, 797 }, new int[] { 3019, 798 }, new int[] { 3027, 800 }, new int[] { 3036, 802 }, new int[] { 3043, 804 }, new int[] { 3050, 807 }, new int[] { 3060, 808 }, new int[] { 3063, 809 }, new int[] { 3071, 810 }, new int[] { 3080, 811 }, new int[] { 3086, 812 }, new int[] { 3094, 813 }, new int[] { 3099, 814 }, new int[] { 3108, 816 }, new int[] { 3113, 817 }, new int[] { 3119, 818 }, new int[] { 3129, 819 }, new int[] { 3135, 821 }, new int[] { 3142, 821 }, new int[] { 3151, 822 }, new int[] { 3154, 822 }, new int[] { 3158, 822 }, new int[] { 3162, 822 }, new int[] { 3165, 823 }, new int[] { 3168, 823 }, new int[] { 3169, 823 }, new int[] { 3172, 823 }, new int[] { 3177, 824 }, new int[] { 3180, 824 }, new int[] { 3183, 824 }, new int[] { 3185, 824 }, new int[] { 3187, 823 }, new int[] { 3187, 823 }, new int[] { 3190, 823 }, new int[] { 3192, 823 }, new int[] { 3194, 823 }, new int[] { 3196, 823 }, new int[] { 3199, 822 }, new int[] { 3200, 822 }, new int[] { 3201, 822 }, new int[] { 3202, 822 }, new int[] { 3204, 822 }, new int[] { 3205, 822 }, new int[] { 3206, 822 }, new int[] { 3209, 821 }, new int[] { 3212, 821 }, new int[] { 3213, 821 }, new int[] { 3213, 821 }, new int[] { 3213, 821 }, new int[] { 3215, 821 }, new int[] { 3216, 821 }, new int[] { 3219, 821 }, new int[] { 3223, 821 }, new int[] { 3225, 821 }, new int[] { 3228, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }, new int[] { 3230, 821 }};
        //int[][] m5 = new int[][] { new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3230, 821}, new int[]{3241, 814}, new int[]{3247, 809}, new int[]{3264, 792}, new int[]{3272, 785}, new int[]{3282, 775}, new int[]{3292, 767}, new int[]{3300, 760}, new int[]{3311, 748}, new int[]{3319, 738}, new int[]{3329, 724}, new int[]{3342, 705}, new int[]{3345, 701}, new int[]{3354, 687}, new int[]{3365, 671}, new int[]{3374, 656}, new int[]{3382, 642}, new int[]{3391, 630}, new int[]{3397, 614}, new int[]{3405, 602}, new int[]{3416, 584}, new int[]{3426, 562}, new int[]{3441, 539}, new int[]{3447, 526}, new int[]{3458, 511}, new int[]{3470, 491}, new int[]{3479, 476}, new int[]{3496, 449}, new int[]{3502, 437}, new int[]{3510, 421}, new int[]{3524, 402}, new int[]{3529, 394}, new int[]{3538, 380}, new int[]{3551, 358}, new int[]{3556, 351}, new int[]{3565, 338}, new int[]{3573, 322}, new int[]{3580, 312}, new int[]{3587, 302}, new int[]{3594, 291}, new int[]{3600, 278}, new int[]{3602, 276}, new int[]{3606, 267}, new int[]{3611, 256}, new int[]{3613, 250}, new int[]{3615, 242}, new int[]{3619, 236}, new int[]{3621, 228}, new int[]{3622, 224}, new int[]{3622, 220}, new int[]{3623, 218}, new int[]{3623, 216}, new int[]{3624, 215}, new int[]{3624, 212}, new int[]{3625, 210}, new int[]{3625, 208}, new int[]{3626, 205}, new int[]{3627, 202}, new int[]{3629, 194}, new int[]{3631, 187}, new int[]{3634, 174}, new int[]{3635, 169}, new int[]{3638, 157}, new int[]{3639, 152}, new int[]{3641, 148}, new int[]{3641, 148}, new int[]{3641, 148}, new int[]{3641, 148}, new int[]{3641, 148}, new int[]{3642, 145}, new int[]{3642, 143}, new int[]{3643, 142}, new int[]{3644, 139}, new int[]{3645, 138}, new int[]{3645, 137}, new int[]{3646, 136}, new int[]{3646, 136}, new int[]{3647, 135}, new int[]{3649, 132}, new int[]{3649, 131}, new int[]{3650, 130}, new int[]{3651, 129}, new int[]{3652, 128}, new int[]{3654, 126}, new int[]{3655, 125}, new int[]{3657, 122}, new int[]{3659, 119}, new int[]{3659, 118}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 117}, new int[]{3660, 120}, new int[]{3660, 121}, new int[]{3660, 123}, new int[]{3660, 125}, new int[]{3660, 127}, new int[]{3662, 129}, new int[]{3662, 131}, new int[]{3663, 133}, new int[]{3664, 136}, new int[]{3664, 138}, new int[]{3666, 141}, new int[]{3666, 142}, new int[]{3667, 145}, new int[]{3667, 147}, new int[]{3668, 151}, new int[]{3669, 152}, new int[]{3670, 155}, new int[]{3670, 156}, new int[]{3671, 159}, new int[]{3671, 160}, new int[]{3671, 163}, new int[]{3671, 164}, new int[]{3671, 164}, new int[]{3671, 166}, new int[]{3671, 167}, new int[]{3671, 167}, new int[]{3671, 169}, new int[]{3671, 169}, new int[]{3671, 170}, new int[]{3671, 170}, new int[]{3671, 170}, new int[]{3671, 170}, new int[]{3671, 170}, new int[]{3671, 170}, new int[]{3671, 170}, new int[]{3671, 170}, new int[]{3671, 170}, new int[]{3671, 170}, new int[]{3671, 170}, new int[]{3671, 170}, new int[]{3672, 170}, new int[]{3672, 170}, new int[]{3672, 170}, new int[]{3672, 170}, new int[]{3673, 170}, new int[]{3674, 169}, new int[]{3674, 169}, new int[]{3674, 169}, new int[]{3674, 169}, new int[]{3675, 169}, new int[]{3676, 168}, new int[]{3677, 168}, new int[]{3678, 166}, new int[]{3679, 165}, new int[]{3680, 165}, new int[]{3682, 163}, new int[]{3682, 163}, new int[]{3683, 161}, new int[]{3684, 160}, new int[]{3686, 159}, new int[]{3686, 159}, new int[]{3687, 157}, new int[]{3688, 156}, new int[]{3689, 155}, new int[]{3690, 154}, new int[]{3691, 152}, new int[]{3692, 151}, new int[]{3693, 149}, new int[]{3694, 149}, new int[]{3695, 147}, new int[]{3696, 146}, new int[]{3696, 145}, new int[]{3697, 144}, new int[]{3698, 143}, new int[]{3699, 142}, new int[]{3699, 141}, new int[]{3700, 140}, new int[]{3701, 139}, new int[]{3701, 137}, new int[]{3702, 136}, new int[]{3704, 134}, new int[]{3704, 133}, new int[]{3705, 132}, new int[]{3707, 131}, new int[]{3707, 130}, new int[]{3708, 129}, new int[]{3708, 128}, new int[]{3709, 127}, new int[]{3709, 127}, new int[]{3711, 126}, new int[]{3711, 126}, new int[]{3711, 126}, new int[]{3712, 126}, new int[]{3712, 125}, new int[]{3712, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3713, 124}, new int[]{3712, 124}, new int[]{3711, 124}, new int[]{3711, 124}, new int[]{3710, 124}, new int[]{3710, 125}, new int[]{3707, 125}, new int[]{3702, 127}, new int[]{3700, 128}, new int[]{3693, 130}, new int[]{3683, 131}, new int[]{3678, 131}, new int[]{3671, 132}, new int[]{3668, 132}, new int[]{3662, 134}, new int[]{3659, 135}, new int[]{3651, 137}, new int[]{3646, 138}, new int[]{3630, 143}, new int[]{3623, 145}, new int[]{3599, 152}, new int[]{3569, 161}, new int[]{3550, 163}, new int[]{3519, 169}, new int[]{3472, 174}, new int[]{3431, 183}, new int[]{3370, 197}, new int[]{3342, 205}, new int[]{3300, 218}, new int[]{3269, 229}, new int[]{3219, 245}, new int[]{3194, 250}, new int[]{3167, 259}, new int[]{3144, 264}, new int[]{3116, 272}, new int[]{3101, 276}, new int[]{3090, 280}, new int[]{3075, 286}, new int[]{3057, 295}, new int[]{3048, 298}, new int[]{3033, 306}, new int[]{3013, 314}, new int[]{3000, 319}, new int[]{2981, 326}, new int[]{2967, 330}, new int[]{2951, 335}, new int[]{2938, 339}, new int[]{2934, 340}, new int[]{2927, 343}, new int[]{2922, 345}, new int[]{2915, 347}, new int[]{2911, 349}, new int[]{2909, 349}, new int[]{2906, 351}, new int[]{2905, 351}, new int[]{2903, 352}, new int[]{2902, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 352}, new int[]{2901, 353}, new int[]{2895, 354}, new int[]{2891, 355}, new int[]{2880, 358}, new int[]{2859, 365}, new int[]{2832, 373}, new int[]{2805, 378}, new int[]{2764, 387}, new int[]{2711, 393}, new int[]{2652, 396}, new int[]{2630, 397}, new int[]{2605, 397}, new int[]{2558, 397}, new int[]{2540, 397}, new int[]{2509, 396}, new int[]{2487, 395}, new int[]{2453, 392}, new int[]{2430, 389}, new int[]{2426, 389}, new int[]{2414, 389}, new int[]{2407, 389}, new int[]{2405, 389}, new int[]{2404, 389}, new int[]{2403, 389}, new int[]{2402, 389}, new int[]{2401, 391}, new int[]{2401, 393}, new int[]{2401, 396}, new int[]{2401, 397}, new int[]{2401, 398}, new int[]{2402, 398}, new int[]{2402, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2403, 398}, new int[]{2404, 398}, new int[]{2406, 398}, new int[]{2407, 397}, new int[]{2410, 396}, new int[]{2415, 393}, new int[]{2419, 392}, new int[]{2425, 390}, new int[]{2436, 386}, new int[]{2442, 383}, new int[]{2459, 377}, new int[]{2478, 370}, new int[]{2501, 361}, new int[]{2519, 354}, new int[]{2539, 347}, new int[]{2570, 336}, new int[]{2585, 332}, new int[]{2605, 326}, new int[]{2622, 322}, new int[]{2628, 320}, new int[]{2639, 318}, new int[]{2653, 313}, new int[]{2674, 306}, new int[]{2688, 302}, new int[]{2721, 292}, new int[]{2730, 287}, new int[]{2772, 275}, new int[]{2803, 264}, new int[]{2852, 248}, new int[]{2901, 235}, new int[]{2937, 225}, new int[]{2986, 215}, new int[]{3021, 210}, new int[]{3055, 205}, new int[]{3097, 199}, new int[]{3128, 195}, new int[]{3161, 188}, new int[]{3178, 184}, new int[]{3203, 177}, new int[]{3209, 176}, new int[]{3228, 171}, new int[]{3244, 167}, new int[]{3261, 161}, new int[]{3277, 157}, new int[]{3296, 152}, new int[]{3305, 151}, new int[]{3322, 148}, new int[]{3341, 146}, new int[]{3363, 143}, new int[]{3371, 142}, new int[]{3400, 142}, new int[]{3426, 141}, new int[]{3439, 141}, new int[]{3478, 141}, new int[]{3522, 141}, new int[]{3538, 142}, new int[]{3562, 143}, new int[]{3588, 143}, new int[]{3597, 144}, new int[]{3614, 144}, new int[]{3621, 144}, new int[]{3629, 145}, new int[]{3635, 145}, new int[]{3638, 145}, new int[]{3642, 145}, new int[]{3644, 145}, new int[]{3647, 144}, new int[]{3649, 144}, new int[]{3650, 143}, new int[]{3653, 142}, new int[]{3655, 142}, new int[]{3657, 141}, new int[]{3659, 140}, new int[]{3664, 138}, new int[]{3667, 136}, new int[]{3674, 133}, new int[]{3676, 131}, new int[]{3680, 130}, new int[]{3682, 128}, new int[]{3683, 127}, new int[]{3686, 126}, new int[]{3686, 126}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 125}, new int[]{3687, 126}, new int[]{3687, 128}, new int[]{3687, 130}, new int[]{3686, 133}, new int[]{3685, 135}, new int[]{3684, 137}, new int[]{3683, 139}, new int[]{3682, 145}, new int[]{3681, 148}, new int[]{3677, 158}, new int[]{3675, 164}, new int[]{3669, 178}, new int[]{3668, 183}, new int[]{3666, 192}, new int[]{3666, 204}, new int[]{3666, 211}, new int[]{3666, 222}, new int[]{3665, 236}, new int[]{3665, 252}, new int[]{3664, 262}, new int[]{3664, 273}, new int[]{3664, 285}, new int[]{3664, 304}, new int[]{3664, 313}, new int[]{3664, 333}, new int[]{3665, 347}, new int[]{3667, 362}, new int[]{3670, 376}, new int[]{3672, 385}, new int[]{3674, 393}, new int[]{3675, 405}, new int[]{3676, 412}, new int[]{3676, 422}, new int[]{3676, 434}, new int[]{3676, 437}, new int[]{3676, 446}, new int[]{3676, 450}, new int[]{3676, 455}, new int[]{3676, 458}, new int[]{3676, 463}, new int[]{3676, 466}, new int[]{3676, 470}, new int[]{3676, 474}, new int[]{3677, 480}, new int[]{3677, 483}, new int[]{3678, 489}, new int[]{3678, 491}, new int[]{3678, 493}, new int[]{3678, 495}, new int[]{3678, 499}, new int[]{3678, 502}, new int[]{3678, 504}, new int[]{3678, 508}, new int[]{3678, 512}, new int[]{3678, 516}, new int[]{3678, 520}, new int[]{3678, 522}, new int[]{3679, 525}, new int[]{3679, 528}, new int[]{3679, 531}, new int[]{3679, 533}, new int[]{3679, 536}, new int[]{3679, 539}, new int[]{3679, 541}, new int[]{3679, 542}, new int[]{3679, 544}, new int[]{3679, 547}, new int[]{3679, 548}, new int[]{3679, 549}, new int[]{3679, 552}, new int[]{3679, 553}, new int[]{3679, 556}, new int[]{3679, 556}, new int[]{3679, 557}, new int[]{3679, 558}, new int[]{3678, 559}, new int[]{3678, 560}, new int[]{3678, 561}, new int[]{3676, 562}, new int[]{3676, 564}, new int[]{3675, 565}, new int[]{3675, 566}, new int[]{3674, 567}, new int[]{3674, 567}, new int[]{3673, 567}, new int[]{3673, 568}, new int[]{3673, 568}, new int[]{3672, 568}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}, new int[]{3672, 569}};
        //int[][] m6 = new int[][] { new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 567}, new int[]{3638, 565}, new int[]{3638, 555}, new int[]{3636, 540}, new int[]{3634, 533}, new int[]{3628, 509}, new int[]{3627, 495}, new int[]{3625, 479}, new int[]{3625, 458}, new int[]{3625, 449}, new int[]{3627, 439}, new int[]{3634, 420}, new int[]{3636, 414}, new int[]{3639, 405}, new int[]{3641, 394}, new int[]{3646, 381}, new int[]{3648, 376}, new int[]{3653, 363}, new int[]{3656, 358}, new int[]{3660, 350}, new int[]{3666, 339}, new int[]{3670, 328}, new int[]{3674, 312}, new int[]{3677, 292}, new int[]{3677, 273}, new int[]{3677, 251}, new int[]{3677, 244}, new int[]{3677, 234}, new int[]{3677, 230}, new int[]{3677, 223}, new int[]{3677, 216}, new int[]{3674, 208}, new int[]{3672, 197}, new int[]{3669, 192}, new int[]{3666, 183}, new int[]{3665, 180}, new int[]{3663, 176}, new int[]{3662, 173}, new int[]{3661, 172}, new int[]{3660, 171}, new int[]{3659, 169}, new int[]{3659, 168}, new int[]{3659, 164}, new int[]{3659, 160}, new int[]{3659, 159}, new int[]{3658, 155}, new int[]{3658, 153}, new int[]{3656, 152}, new int[]{3656, 151}, new int[]{3655, 149}, new int[]{3655, 148}, new int[]{3655, 145}, new int[]{3654, 143}, new int[]{3654, 141}, new int[]{3653, 139}, new int[]{3652, 138}, new int[]{3652, 137}, new int[]{3651, 136}, new int[]{3651, 135}, new int[]{3651, 134}, new int[]{3651, 133}, new int[]{3651, 132}, new int[]{3651, 131}, new int[]{3651, 129}, new int[]{3651, 127}, new int[]{3651, 126}, new int[]{3651, 125}, new int[]{3651, 124}, new int[]{3651, 123}, new int[]{3651, 123}, new int[]{3651, 123}, new int[]{3651, 123}, new int[]{3651, 123}, new int[]{3651, 122}, new int[]{3651, 122}, new int[]{3651, 122}, new int[]{3651, 122}, new int[]{3651, 122}, new int[]{3651, 122}, new int[]{3651, 122}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3651, 121}, new int[]{3649, 122}, new int[]{3649, 122}, new int[]{3647, 123}, new int[]{3647, 124}, new int[]{3645, 125}, new int[]{3643, 127}, new int[]{3641, 130}, new int[]{3636, 133}, new int[]{3633, 135}, new int[]{3628, 138}, new int[]{3614, 145}, new int[]{3608, 149}, new int[]{3589, 157}, new int[]{3578, 162}, new int[]{3564, 167}, new int[]{3546, 175}, new int[]{3530, 182}, new int[]{3512, 189}, new int[]{3495, 198}, new int[]{3475, 207}, new int[]{3459, 213}, new int[]{3439, 222}, new int[]{3427, 228}, new int[]{3408, 237}, new int[]{3400, 241}, new int[]{3392, 245}, new int[]{3382, 249}, new int[]{3373, 253}, new int[]{3357, 261}, new int[]{3347, 265}, new int[]{3336, 271}, new int[]{3319, 279}, new int[]{3305, 288}, new int[]{3287, 296}, new int[]{3267, 303}, new int[]{3239, 315}, new int[]{3224, 321}, new int[]{3201, 330}, new int[]{3195, 332}, new int[]{3176, 340}, new int[]{3167, 344}, new int[]{3157, 348}, new int[]{3146, 353}, new int[]{3134, 359}, new int[]{3129, 361}, new int[]{3114, 368}, new int[]{3106, 372}, new int[]{3089, 380}, new int[]{3083, 383}, new int[]{3067, 392}, new int[]{3059, 395}, new int[]{3045, 401}, new int[]{3028, 409}, new int[]{3021, 411}, new int[]{3005, 417}, new int[]{2996, 421}, new int[]{2982, 427}, new int[]{2976, 430}, new int[]{2966, 435}, new int[]{2962, 438}, new int[]{2950, 444}, new int[]{2946, 447}, new int[]{2937, 452}, new int[]{2928, 455}, new int[]{2919, 459}, new int[]{2904, 466}, new int[]{2896, 469}, new int[]{2888, 472}, new int[]{2879, 477}, new int[]{2873, 480}, new int[]{2859, 485}, new int[]{2852, 488}, new int[]{2847, 490}, new int[]{2835, 495}, new int[]{2827, 498}, new int[]{2822, 500}, new int[]{2818, 502}, new int[]{2810, 505}, new int[]{2807, 507}, new int[]{2801, 508}, new int[]{2793, 512}, new int[]{2788, 514}, new int[]{2783, 517}, new int[]{2779, 518}, new int[]{2774, 521}, new int[]{2770, 522}, new int[]{2765, 524}, new int[]{2761, 524}, new int[]{2753, 528}, new int[]{2748, 530}, new int[]{2744, 531}, new int[]{2739, 533}, new int[]{2735, 535}, new int[]{2732, 535}, new int[]{2729, 537}, new int[]{2725, 539}, new int[]{2723, 540}, new int[]{2719, 542}, new int[]{2714, 544}, new int[]{2712, 545}, new int[]{2711, 545}, new int[]{2708, 546}, new int[]{2705, 546}, new int[]{2700, 547}, new int[]{2700, 548}, new int[]{2697, 548}, new int[]{2695, 548}, new int[]{2695, 548}, new int[]{2693, 548}, new int[]{2692, 548}, new int[]{2691, 548}, new int[]{2688, 548}, new int[]{2684, 548}, new int[]{2682, 548}, new int[]{2677, 548}, new int[]{2676, 548}, new int[]{2674, 548}, new int[]{2674, 548}, new int[]{2673, 548}, new int[]{2673, 550}, new int[]{2672, 550}, new int[]{2671, 550}, new int[]{2671, 550}, new int[]{2671, 550}, new int[]{2671, 550}, new int[]{2671, 550}, new int[]{2671, 550}, new int[]{2671, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}, new int[]{2670, 550}};

        int[][] m5 = new int[][] { new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 810}, new int[]{3211, 809}, new int[]{3214, 804}, new int[]{3216, 802}, new int[]{3220, 797}, new int[]{3223, 793}, new int[]{3229, 786}, new int[]{3233, 782}, new int[]{3240, 775}, new int[]{3251, 759}, new int[]{3257, 752}, new int[]{3272, 735}, new int[]{3285, 718}, new int[]{3295, 704}, new int[]{3309, 685}, new int[]{3317, 675}, new int[]{3327, 658}, new int[]{3335, 645}, new int[]{3342, 633}, new int[]{3347, 624}, new int[]{3353, 610}, new int[]{3355, 605}, new int[]{3360, 595}, new int[]{3365, 588}, new int[]{3369, 579}, new int[]{3373, 571}, new int[]{3377, 563}, new int[]{3383, 550}, new int[]{3390, 542}, new int[]{3396, 528}, new int[]{3403, 515}, new int[]{3409, 506}, new int[]{3418, 492}, new int[]{3421, 487}, new int[]{3430, 475}, new int[]{3433, 470}, new int[]{3438, 463}, new int[]{3447, 449}, new int[]{3452, 442}, new int[]{3461, 432}, new int[]{3468, 423}, new int[]{3474, 413}, new int[]{3478, 408}, new int[]{3482, 402}, new int[]{3489, 392}, new int[]{3493, 386}, new int[]{3500, 374}, new int[]{3504, 369}, new int[]{3508, 362}, new int[]{3514, 352}, new int[]{3517, 348}, new int[]{3522, 342}, new int[]{3527, 333}, new int[]{3530, 329}, new int[]{3534, 323}, new int[]{3541, 313}, new int[]{3544, 310}, new int[]{3549, 303}, new int[]{3555, 295}, new int[]{3558, 291}, new int[]{3563, 285}, new int[]{3570, 275}, new int[]{3573, 271}, new int[]{3576, 268}, new int[]{3580, 263}, new int[]{3588, 257}, new int[]{3592, 254}, new int[]{3601, 247}, new int[]{3604, 244}, new int[]{3608, 240}, new int[]{3612, 236}, new int[]{3617, 233}, new int[]{3621, 230}, new int[]{3626, 224}, new int[]{3627, 223}, new int[]{3632, 220}, new int[]{3634, 218}, new int[]{3637, 213}, new int[]{3641, 209}, new int[]{3643, 208}, new int[]{3646, 203}, new int[]{3648, 201}, new int[]{3650, 198}, new int[]{3652, 196}, new int[]{3654, 192}, new int[]{3655, 190}, new int[]{3657, 188}, new int[]{3661, 185}, new int[]{3662, 183}, new int[]{3664, 180}, new int[]{3666, 178}, new int[]{3666, 177}, new int[]{3669, 175}, new int[]{3671, 171}, new int[]{3676, 165}, new int[]{3679, 159}, new int[]{3685, 153}, new int[]{3688, 150}, new int[]{3691, 146}, new int[]{3693, 142}, new int[]{3695, 140}, new int[]{3695, 139}, new int[]{3695, 138}, new int[]{3696, 137}, new int[]{3696, 137}, new int[]{3696, 137}, new int[]{3697, 136}, new int[]{3697, 135}, new int[]{3698, 134}, new int[]{3698, 133}, new int[]{3699, 132}, new int[]{3699, 130}, new int[]{3699, 129}, new int[]{3699, 128}, new int[]{3699, 128}, new int[]{3699, 127}, new int[]{3699, 127}, new int[]{3699, 127}, new int[]{3700, 125}, new int[]{3702, 123}, new int[]{3703, 122}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}, new int[]{3703, 120}};
        int[][] m6 = new int[][] {new int[]{3702, 122}, new int[]{3702, 122}, new int[]{3702, 122}, new int[]{3702, 122}, new int[]{3702, 122}, new int[]{3702, 122}, new int[]{3702, 122}, new int[]{3702, 122}, new int[]{3702, 122}, new int[]{3702, 122}, new int[]{3702, 122}, new int[]{3702, 122}, new int[]{3702, 122}, new int[]{3702, 124}, new int[]{3702, 125}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 126}, new int[]{3702, 127}, new int[]{3702, 130}, new int[]{3702, 132}, new int[]{3702, 134}, new int[]{3702, 138}, new int[]{3702, 140}, new int[]{3702, 145}, new int[]{3702, 149}, new int[]{3702, 155}, new int[]{3702, 159}, new int[]{3702, 163}, new int[]{3702, 174}, new int[]{3702, 180}, new int[]{3702, 190}, new int[]{3703, 197}, new int[]{3704, 207}, new int[]{3705, 224}, new int[]{3706, 229}, new int[]{3708, 238}, new int[]{3709, 247}, new int[]{3710, 254}, new int[]{3711, 262}, new int[]{3712, 266}, new int[]{3712, 271}, new int[]{3712, 281}, new int[]{3712, 286}, new int[]{3712, 295}, new int[]{3712, 299}, new int[]{3711, 308}, new int[]{3711, 313}, new int[]{3711, 321}, new int[]{3711, 326}, new int[]{3711, 333}, new int[]{3711, 337}, new int[]{3710, 342}, new int[]{3707, 349}, new int[]{3706, 353}, new int[]{3705, 357}, new int[]{3703, 365}, new int[]{3702, 369}, new int[]{3702, 376}, new int[]{3701, 378}, new int[]{3701, 383}, new int[]{3700, 390}, new int[]{3699, 393}, new int[]{3699, 401}, new int[]{3699, 405}, new int[]{3699, 412}, new int[]{3699, 415}, new int[]{3699, 420}, new int[]{3699, 424}, new int[]{3699, 428}, new int[]{3699, 432}, new int[]{3699, 437}, new int[]{3699, 440}, new int[]{3699, 444}, new int[]{3699, 451}, new int[]{3699, 454}, new int[]{3699, 459}, new int[]{3699, 464}, new int[]{3699, 466}, new int[]{3699, 472}, new int[]{3700, 475}, new int[]{3701, 479}, new int[]{3702, 484}, new int[]{3703, 487}, new int[]{3703, 492}, new int[]{3703, 495}, new int[]{3703, 500}, new int[]{3703, 502}, new int[]{3703, 506}, new int[]{3703, 510}, new int[]{3703, 516}, new int[]{3703, 519}, new int[]{3703, 523}, new int[]{3702, 529}, new int[]{3701, 531}, new int[]{3699, 537}, new int[]{3697, 542}, new int[]{3694, 548}, new int[]{3691, 554}, new int[]{3690, 555}, new int[]{3687, 559}, new int[]{3685, 563}, new int[]{3684, 565}, new int[]{3680, 567}, new int[]{3679, 570}, new int[]{3678, 570}, new int[]{3677, 571}, new int[]{3676, 571}, new int[]{3676, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 572}, new int[]{3675, 571}, new int[]{3675, 571}, new int[]{3675, 571}, new int[]{3675, 571}, new int[]{3675, 571}, new int[]{3675, 569}, new int[]{3675, 567}, new int[]{3675, 567}, new int[]{3675, 565}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564} };
        int[][] m7 = new int[][] { new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3672, 121}, new int[]{3670, 122}, new int[]{3669, 122}, new int[]{3666, 124}, new int[]{3664, 125}, new int[]{3662, 126}, new int[]{3659, 128}, new int[]{3657, 129}, new int[]{3652, 130}, new int[]{3649, 132}, new int[]{3645, 133}, new int[]{3636, 136}, new int[]{3631, 138}, new int[]{3622, 142}, new int[]{3620, 143}, new int[]{3615, 145}, new int[]{3608, 149}, new int[]{3604, 152}, new int[]{3595, 155}, new int[]{3590, 158}, new int[]{3584, 161}, new int[]{3578, 163}, new int[]{3572, 167}, new int[]{3564, 172}, new int[]{3555, 177}, new int[]{3551, 178}, new int[]{3545, 181}, new int[]{3533, 184}, new int[]{3528, 186}, new int[]{3520, 189}, new int[]{3510, 194}, new int[]{3505, 196}, new int[]{3496, 200}, new int[]{3488, 203}, new int[]{3474, 211}, new int[]{3470, 213}, new int[]{3453, 222}, new int[]{3442, 227}, new int[]{3418, 238}, new int[]{3406, 242}, new int[]{3389, 249}, new int[]{3371, 255}, new int[]{3353, 263}, new int[]{3330, 270}, new int[]{3312, 276}, new int[]{3301, 281}, new int[]{3283, 289}, new int[]{3272, 294}, new int[]{3258, 299}, new int[]{3243, 306}, new int[]{3228, 312}, new int[]{3218, 315}, new int[]{3204, 320}, new int[]{3197, 323}, new int[]{3185, 327}, new int[]{3182, 328}, new int[]{3176, 330}, new int[]{3169, 333}, new int[]{3163, 335}, new int[]{3157, 338}, new int[]{3148, 342}, new int[]{3142, 345}, new int[]{3134, 348}, new int[]{3127, 351}, new int[]{3119, 356}, new int[]{3110, 361}, new int[]{3097, 367}, new int[]{3088, 371}, new int[]{3072, 380}, new int[]{3063, 384}, new int[]{3052, 389}, new int[]{3033, 399}, new int[]{3025, 402}, new int[]{3009, 410}, new int[]{3004, 413}, new int[]{2990, 419}, new int[]{2982, 423}, new int[]{2974, 426}, new int[]{2966, 430}, new int[]{2961, 432}, new int[]{2954, 436}, new int[]{2949, 439}, new int[]{2945, 440}, new int[]{2935, 444}, new int[]{2931, 446}, new int[]{2919, 452}, new int[]{2912, 455}, new int[]{2902, 460}, new int[]{2886, 467}, new int[]{2877, 471}, new int[]{2858, 477}, new int[]{2850, 481}, new int[]{2837, 486}, new int[]{2827, 490}, new int[]{2813, 494}, new int[]{2798, 499}, new int[]{2790, 502}, new int[]{2778, 507}, new int[]{2776, 508}, new int[]{2767, 511}, new int[]{2763, 513}, new int[]{2759, 514}, new int[]{2752, 517}, new int[]{2745, 519}, new int[]{2738, 522}, new int[]{2727, 524}, new int[]{2716, 526}, new int[]{2709, 526}, new int[]{2704, 527}, new int[]{2700, 528}, new int[]{2695, 530}, new int[]{2693, 531}, new int[]{2690, 532}, new int[]{2690, 532}, new int[]{2690, 533}, new int[]{2689, 533}, new int[]{2688, 533}, new int[]{2688, 533}, new int[]{2688, 534}, new int[]{2688, 535}, new int[]{2687, 537}, new int[]{2687, 539}, new int[]{2686, 540}, new int[]{2686, 542}, new int[]{2686, 543}, new int[]{2686, 543}, new int[]{2685, 545}, new int[]{2684, 545}, new int[]{2683, 546}, new int[]{2683, 547}, new int[]{2682, 548}, new int[]{2682, 549}, new int[]{2680, 550}, new int[]{2680, 550}, new int[]{2679, 551}, new int[]{2679, 551}, new int[]{2679, 551}, new int[]{2679, 551}, new int[]{2679, 551}, new int[]{2679, 551}, new int[]{2679, 551}, new int[]{2679, 551}, new int[]{2679, 551}, new int[]{2679, 551}, new int[]{2679, 551}, new int[]{2679, 551}, new int[]{2679, 551}, new int[]{2679, 551}, new int[]{2679, 549}, new int[]{2678, 548}, new int[]{2678, 547}, new int[]{2678, 547}, new int[]{2678, 546}, new int[]{2678, 546}, new int[]{2678, 546}, new int[]{2678, 546}, new int[]{2678, 546}, new int[]{2678, 546}, new int[]{2678, 546}, new int[]{2678, 546}, new int[]{2678, 545}, new int[]{2678, 545}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}, new int[]{2678, 544}};

        int[][] m8 = new int[][] { new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3675, 564}, new int[]{3673, 563}, new int[]{3666, 563}, new int[]{3660, 562}, new int[]{3643, 560}, new int[]{3606, 555}, new int[]{3584, 550}, new int[]{3554, 546}, new int[]{3519, 540}, new int[]{3510, 538}, new int[]{3500, 535}, new int[]{3486, 530}, new int[]{3475, 527}, new int[]{3461, 522}, new int[]{3444, 516}, new int[]{3429, 510}, new int[]{3396, 499}, new int[]{3380, 493}, new int[]{3349, 482}, new int[]{3320, 473}, new int[]{3280, 460}, new int[]{3267, 455}, new int[]{3224, 442}, new int[]{3208, 438}, new int[]{3180, 430}, new int[]{3134, 423}, new int[]{3092, 416}, new int[]{3071, 413}, new int[]{3048, 411}, new int[]{3011, 403}, new int[]{2974, 397}, new int[]{2916, 385}, new int[]{2894, 381}, new int[]{2855, 371}, new int[]{2811, 358}, new int[]{2784, 350}, new int[]{2750, 339}, new int[]{2716, 327}, new int[]{2676, 312}, new int[]{2630, 295}, new int[]{2605, 285}, new int[]{2565, 267}, new int[]{2550, 260}, new int[]{2535, 253}, new int[]{2514, 243}, new int[]{2506, 239}, new int[]{2494, 231}, new int[]{2480, 221}, new int[]{2474, 217}, new int[]{2463, 209}, new int[]{2454, 203}, new int[]{2444, 195}, new int[]{2434, 188}, new int[]{2425, 182}, new int[]{2410, 173}, new int[]{2396, 164}, new int[]{2390, 159}, new int[]{2380, 150}, new int[]{2370, 141}, new int[]{2360, 130}, new int[]{2354, 126}, new int[]{2350, 122}, new int[]{2342, 114}, new int[]{2340, 112}, new int[]{2336, 107}, new int[]{2332, 100}, new int[]{2329, 96}, new int[]{2324, 88}, new int[]{2323, 84}, new int[]{2318, 78}, new int[]{2315, 72}, new int[]{2312, 67}, new int[]{2309, 62}, new int[]{2306, 56}, new int[]{2304, 51}, new int[]{2301, 47}, new int[]{2298, 43}, new int[]{2295, 40}, new int[]{2294, 38}, new int[]{2292, 34}, new int[]{2291, 33}, new int[]{2291, 32}, new int[]{2290, 32}, new int[]{2290, 31}, new int[]{2290, 30}, new int[]{2289, 28}, new int[]{2286, 23}, new int[]{2283, 19}, new int[]{2281, 15}, new int[]{2280, 15}, new int[]{2280, 14}, new int[]{2280, 14}, new int[]{2280, 14}, new int[]{2279, 14}, new int[]{2279, 14}, new int[]{2279, 14}, new int[]{2279, 14}, new int[]{2279, 14}, new int[]{2279, 14}, new int[]{2279, 14}, new int[]{2279, 14}, new int[]{2279, 14}, new int[]{2279, 14}, new int[]{2279, 14}, new int[]{2279, 14}, new int[]{2279, 14}, new int[]{2279, 14}, new int[]{2279, 14}};
        int[][] m9 = new int[][] { new int[]{2305, 16}, new int[]{2305, 16}, new int[]{2305, 16}, new int[]{2305, 16}, new int[]{2305, 16}, new int[]{2305, 16}, new int[]{2305, 16}, new int[]{2305, 16}, new int[]{2305, 16}, new int[]{2305, 16}, new int[]{2305, 18}, new int[]{2305, 21}, new int[]{2305, 27}, new int[]{2306, 31}, new int[]{2310, 47}, new int[]{2314, 56}, new int[]{2321, 75}, new int[]{2328, 95}, new int[]{2338, 126}, new int[]{2344, 142}, new int[]{2350, 161}, new int[]{2356, 182}, new int[]{2360, 198}, new int[]{2365, 213}, new int[]{2370, 226}, new int[]{2375, 242}, new int[]{2378, 250}, new int[]{2380, 273}, new int[]{2381, 283}, new int[]{2385, 311}, new int[]{2387, 324}, new int[]{2392, 343}, new int[]{2395, 359}, new int[]{2406, 387}, new int[]{2413, 403}, new int[]{2423, 424}, new int[]{2439, 456}, new int[]{2450, 477}, new int[]{2464, 501}, new int[]{2476, 522}, new int[]{2495, 554}, new int[]{2505, 572}, new int[]{2513, 589}, new int[]{2527, 611}, new int[]{2536, 626}, new int[]{2545, 639}, new int[]{2557, 661}, new int[]{2563, 668}, new int[]{2576, 689}, new int[]{2582, 697}, new int[]{2591, 710}, new int[]{2598, 718}, new int[]{2607, 728}, new int[]{2615, 736}, new int[]{2624, 743}, new int[]{2636, 752}, new int[]{2641, 756}, new int[]{2646, 760}, new int[]{2653, 767}, new int[]{2662, 773}, new int[]{2673, 782}, new int[]{2684, 790}, new int[]{2691, 797}, new int[]{2702, 803}, new int[]{2710, 809}, new int[]{2721, 817}, new int[]{2724, 818}, new int[]{2732, 824}, new int[]{2736, 828}, new int[]{2746, 833}, new int[]{2751, 836}, new int[]{2757, 840}, new int[]{2762, 842}, new int[]{2767, 845}, new int[]{2775, 848}, new int[]{2784, 851}, new int[]{2787, 852}, new int[]{2794, 854}, new int[]{2806, 856}, new int[]{2811, 857}, new int[]{2817, 859}, new int[]{2822, 860}, new int[]{2826, 860}, new int[]{2827, 860}, new int[]{2828, 860}, new int[]{2829, 860}, new int[]{2829, 860}, new int[]{2831, 860}, new int[]{2833, 860}, new int[]{2834, 858}, new int[]{2835, 857}, new int[]{2838, 855}, new int[]{2838, 853}, new int[]{2840, 851}, new int[]{2840, 851}, new int[]{2841, 850}, new int[]{2841, 850}, new int[]{2841, 850}, new int[]{2841, 849}, new int[]{2841, 849}, new int[]{2842, 849}, new int[]{2842, 849}, new int[]{2842, 849}, new int[]{2842, 849}, new int[]{2842, 849}, new int[]{2842, 849}, new int[]{2842, 849}, new int[]{2842, 849}, new int[]{2842, 849}, new int[]{2842, 849}, new int[]{2842, 849}};
        int[][] m10 = new int[][] { new int[]{2929, 848}, new int[]{2929, 848}, new int[]{2929, 848}, new int[]{2929, 848}, new int[]{2929, 848}, new int[]{2929, 848}, new int[]{2929, 848}, new int[]{2929, 848}, new int[]{2929, 848}, new int[]{2929, 848}, new int[]{2929, 848}, new int[]{2929, 848}, new int[]{2929, 848}, new int[]{2929, 848}, new int[]{2929, 848}, new int[]{2930, 848}, new int[]{2932, 847}, new int[]{2935, 844}, new int[]{2937, 843}, new int[]{2940, 840}, new int[]{2944, 838}, new int[]{2947, 835}, new int[]{2950, 833}, new int[]{2953, 828}, new int[]{2955, 825}, new int[]{2957, 822}, new int[]{2961, 816}, new int[]{2962, 814}, new int[]{2965, 810}, new int[]{2969, 808}, new int[]{2971, 805}, new int[]{2974, 801}, new int[]{2974, 800}, new int[]{2977, 796}, new int[]{2979, 793}, new int[]{2981, 791}, new int[]{2983, 787}, new int[]{2985, 785}, new int[]{2987, 783}, new int[]{2990, 779}, new int[]{2992, 777}, new int[]{2993, 777}, new int[]{2995, 775}, new int[]{2995, 775}, new int[]{2997, 773}, new int[]{2998, 772}, new int[]{2998, 772}, new int[]{2999, 771}, new int[]{2999, 771}, new int[]{3001, 770}, new int[]{3001, 770}, new int[]{3002, 770}, new int[]{3003, 769}, new int[]{3005, 768}, new int[]{3006, 768}, new int[]{3009, 768}, new int[]{3011, 768}, new int[]{3017, 768}, new int[]{3019, 768}, new int[]{3021, 768}, new int[]{3022, 768}, new int[]{3023, 768}, new int[]{3024, 768}, new int[]{3026, 768}, new int[]{3030, 768}, new int[]{3033, 768}, new int[]{3035, 768}, new int[]{3039, 768}, new int[]{3044, 768}, new int[]{3046, 768}, new int[]{3049, 768}, new int[]{3053, 768}, new int[]{3055, 768}, new int[]{3060, 768}, new int[]{3062, 768}, new int[]{3064, 768}, new int[]{3067, 769}, new int[]{3068, 769}, new int[]{3071, 769}, new int[]{3073, 769}, new int[]{3074, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}, new int[]{3075, 769}};
        int[][] m11 = new int[][] { new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3078, 776}, new int[]{3076, 776}, new int[]{3073, 776}, new int[]{3072, 776}, new int[]{3072, 776}, new int[]{3072, 776}, new int[]{3070, 773}, new int[]{3069, 772}, new int[]{3067, 769}, new int[]{3064, 767}, new int[]{3055, 760}, new int[]{3049, 755}, new int[]{3037, 747}, new int[]{3032, 744}, new int[]{3026, 741}, new int[]{3017, 737}, new int[]{3012, 734}, new int[]{2993, 722}, new int[]{2980, 718}, new int[]{2943, 703}, new int[]{2911, 688}, new int[]{2884, 677}, new int[]{2852, 663}, new int[]{2817, 650}, new int[]{2796, 641}, new int[]{2774, 630}, new int[]{2737, 611}, new int[]{2716, 599}, new int[]{2700, 590}, new int[]{2667, 571}, new int[]{2654, 564}, new int[]{2625, 546}, new int[]{2616, 540}, new int[]{2597, 527}, new int[]{2582, 518}, new int[]{2568, 509}, new int[]{2554, 497}, new int[]{2545, 491}, new int[]{2535, 483}, new int[]{2530, 477}, new int[]{2520, 468}, new int[]{2516, 464}, new int[]{2508, 455}, new int[]{2492, 442}, new int[]{2474, 428}, new int[]{2462, 419}, new int[]{2436, 400}, new int[]{2418, 388}, new int[]{2406, 379}, new int[]{2385, 364}, new int[]{2368, 353}, new int[]{2361, 349}, new int[]{2349, 339}, new int[]{2332, 323}, new int[]{2326, 317}, new int[]{2309, 301}, new int[]{2297, 290}, new int[]{2278, 272}, new int[]{2269, 264}, new int[]{2250, 244}, new int[]{2239, 235}, new int[]{2221, 218}, new int[]{2206, 203}, new int[]{2196, 186}, new int[]{2185, 164}, new int[]{2181, 158}, new int[]{2174, 147}, new int[]{2166, 134}, new int[]{2158, 122}, new int[]{2153, 115}, new int[]{2145, 104}, new int[]{2136, 97}, new int[]{2131, 92}, new int[]{2120, 84}, new int[]{2108, 77}, new int[]{2104, 74}, new int[]{2096, 69}, new int[]{2091, 66}, new int[]{2087, 62}, new int[]{2081, 55}, new int[]{2080, 53}, new int[]{2079, 50}, new int[]{2078, 47}, new int[]{2077, 45}, new int[]{2077, 43}, new int[]{2076, 40}, new int[]{2076, 38}, new int[]{2076, 37}, new int[]{2076, 36}, new int[]{2076, 34}, new int[]{2077, 32}, new int[]{2077, 32}, new int[]{2079, 31}, new int[]{2081, 29}, new int[]{2081, 28}, new int[]{2082, 26}, new int[]{2084, 24}, new int[]{2084, 24}, new int[]{2085, 22}, new int[]{2086, 21}, new int[]{2087, 20}, new int[]{2088, 20}, new int[]{2088, 20}, new int[]{2088, 20}, new int[]{2089, 20}, new int[]{2089, 20}, new int[]{2089, 19}, new int[]{2089, 19}, new int[]{2089, 19}, new int[]{2089, 19}, new int[]{2089, 19}, new int[]{2089, 19}, new int[]{2089, 19}, new int[]{2089, 18}, new int[]{2089, 18}, new int[]{2089, 18}, new int[]{2090, 18}, new int[]{2092, 16}, new int[]{2092, 16}, new int[]{2094, 15}, new int[]{2094, 14}, new int[]{2094, 14}, new int[]{2095, 13}, new int[]{2095, 13}, new int[]{2096, 12}, new int[]{2096, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}, new int[]{2097, 12}};
        int[][] m12 = new int[][] { new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 3 }, new int[] { 2051, 4 }, new int[] { 2051, 8 }, new int[] { 2052, 16 }, new int[] { 2056, 20 }, new int[] { 2063, 29 }, new int[] { 2079, 44 }, new int[] { 2090, 53 }, new int[] { 2122, 74 }, new int[] { 2147, 90 }, new int[] { 2185, 112 }, new int[] { 2224, 135 }, new int[] { 2291, 173 }, new int[] { 2321, 192 }, new int[] { 2369, 216 }, new int[] { 2417, 242 }, new int[] { 2451, 261 }, new int[] { 2497, 284 }, new int[] { 2556, 312 }, new int[] { 2597, 330 }, new int[] { 2639, 348 }, new int[] { 2690, 369 }, new int[] { 2736, 384 }, new int[] { 2765, 393 }, new int[] { 2805, 406 }, new int[] { 2831, 415 }, new int[] { 2895, 440 }, new int[] { 2932, 454 }, new int[] { 2969, 469 }, new int[] { 3030, 491 }, new int[] { 3060, 502 }, new int[] { 3116, 520 }, new int[] { 3136, 525 }, new int[] { 3188, 538 }, new int[] { 3209, 544 }, new int[] { 3241, 552 }, new int[] { 3268, 560 }, new int[] { 3294, 568 }, new int[] { 3322, 576 }, new int[] { 3334, 579 }, new int[] { 3348, 582 }, new int[] { 3361, 585 }, new int[] { 3373, 587 }, new int[] { 3388, 590 }, new int[] { 3397, 593 }, new int[] { 3406, 596 }, new int[] { 3420, 600 }, new int[] { 3427, 602 }, new int[] { 3440, 605 }, new int[] { 3453, 607 }, new int[] { 3460, 608 }, new int[] { 3467, 609 }, new int[] { 3485, 613 }, new int[] { 3500, 615 }, new int[] { 3509, 617 }, new int[] { 3519, 618 }, new int[] { 3531, 619 }, new int[] { 3541, 620 }, new int[] { 3545, 621 }, new int[] { 3551, 621 }, new int[] { 3553, 622 }, new int[] { 3556, 622 }, new int[] { 3558, 622 }, new int[] { 3562, 622 }, new int[] { 3564, 622 }, new int[] { 3566, 622 }, new int[] { 3568, 621 }, new int[] { 3569, 621 }, new int[] { 3572, 620 }, new int[] { 3573, 619 }, new int[] { 3576, 619 }, new int[] { 3578, 618 }, new int[] { 3580, 617 }, new int[] { 3582, 617 }, new int[] { 3584, 617 }, new int[] { 3585, 616 }, new int[] { 3586, 616 }, new int[] { 3588, 615 }, new int[] { 3589, 615 }, new int[] { 3590, 615 }, new int[] { 3593, 615 }, new int[] { 3594, 615 }, new int[] { 3596, 615 }, new int[] { 3598, 614 }, new int[] { 3599, 614 }, new int[] { 3601, 614 }, new int[] { 3602, 614 }, new int[] { 3604, 614 }, new int[] { 3606, 613 }, new int[] { 3609, 613 }, new int[] { 3610, 613 }, new int[] { 3611, 613 }, new int[] { 3611, 613 }, new int[] { 3613, 613 }, new int[] { 3613, 613 }, new int[] { 3614, 612 }, new int[] { 3614, 612 }, new int[] { 3615, 612 }, new int[] { 3617, 612 }, new int[] { 3619, 612 }, new int[] { 3620, 611 }, new int[] { 3622, 611 }, new int[] { 3623, 611 }, new int[] { 3624, 611 }, new int[] { 3625, 611 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 }, new int[] { 3625, 610 } };

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);


            DoMouseClick();
            Thread.Sleep(10);
            SendKeys.Send("{ENTER}");

            foreach (int[] pos in m1)
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            DoMouseClick();
            Thread.Sleep(50);
            SendKeys.Send("^(a)");
            Thread.Sleep(27);
            SendKeys.Send("{DELETE}");
            Thread.Sleep(20);
            foreach (char let in nextUsername)
            {
                SendKeys.Send(let.ToString());
                Thread.Sleep(50);
            }

            foreach (int[] pos in m2)
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            DoMouseClick();
            Thread.Sleep(50);
            SendKeys.Send("^(a)");
            Thread.Sleep(112);
            SendKeys.Send("{DELETE}");
            Thread.Sleep(45);
            foreach (char let in nextPassword)
            {
                SendKeys.Send(let.ToString());
                Thread.Sleep(50);
            }

            foreach (int[] pos in m3)
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            DoMouseClick();
            Thread.Sleep(753);

            foreach (int[] pos in m4)
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            Thread.Sleep(200);
            DoMouseClick();
            Thread.Sleep(1209);
            DoMouseClick();
            Thread.Sleep(7891);
            foreach (int[] pos in m5)
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            DoMouseClick();
            Thread.Sleep(500);

            foreach (int[] pos in m6)
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            DoMouseClick();
            Thread.Sleep(256);
            foreach (int[] pos in m6.Reverse())
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            DoMouseClick();
            Thread.Sleep(256);

            foreach (int[] pos in m7)
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            DoMouseClick();
            Thread.Sleep(256);
            ind++;
            nextUsername = userNames[ind];
        }

        int cacheClear = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {

            if (cacheClear == 0)
            {
                foreach (int[] pos in m8)
                {
                    Win32.SetCursorPos(pos[0], pos[1]);
                    Thread.Sleep(10);
                }
                DoMouseClick();
                Thread.Sleep(303);

                foreach (int[] pos in m9)
                {
                    Win32.SetCursorPos(pos[0], pos[1]);
                    Thread.Sleep(10);
                }
                DoMouseClick();
                Thread.Sleep(1133);

                foreach (int[] pos in m9)
                {
                    Win32.SetCursorPos(pos[0], pos[1]);
                    Thread.Sleep(10);
                }
                DoMouseClick();
                Thread.Sleep(303);

                foreach (int[] pos in m10)
                {
                    Win32.SetCursorPos(pos[0], pos[1]);
                    Thread.Sleep(10);
                }
                DoMouseClick();
                Thread.Sleep(303);

                foreach (int[] pos in m11)
                {
                    Win32.SetCursorPos(pos[0], pos[1]);
                    Thread.Sleep(10);
                }
                DoMouseClick();
                Thread.Sleep(303);

                foreach (int[] pos in m12)
                {
                    Win32.SetCursorPos(pos[0], pos[1]);
                    Thread.Sleep(10);
                }
                DoMouseClick();
                Thread.Sleep(503);
            }


            SendKeys.Send("^(r)");
            Thread.Sleep(7000);
            foreach (int[] pos in m6.Reverse())
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            DoMouseClick();
            Thread.Sleep(256);
            foreach (int[] pos in m7)
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            DoMouseClick();
            Thread.Sleep(953);
            DoMouseClick();
            Thread.Sleep(10);
            SendKeys.Send("{ENTER}");

            foreach (int[] pos in m1)
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            DoMouseClick();
            Thread.Sleep(50);
            SendKeys.Send("^(a)");
            Thread.Sleep(27);
            SendKeys.Send("{DELETE}");
            Thread.Sleep(20);
            foreach (char let in nextUsername)
            {
                SendKeys.Send(let.ToString());
                Thread.Sleep(50);
            }

            foreach (int[] pos in m2)
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            DoMouseClick();
            Thread.Sleep(50);
            SendKeys.Send("^(a)");
            Thread.Sleep(112);
            SendKeys.Send("{DELETE}");
            Thread.Sleep(45);
            foreach (char let in nextPassword)
            {
                SendKeys.Send(let.ToString());
                Thread.Sleep(50);
            }

            foreach (int[] pos in m3)
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            DoMouseClick();
            Thread.Sleep(753);

            foreach (int[] pos in m4)
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            Thread.Sleep(200);
            DoMouseClick();
            Thread.Sleep(1209);
            DoMouseClick();
            Thread.Sleep(7891);
            foreach (int[] pos in m5)
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            DoMouseClick();
            Thread.Sleep(500);

            foreach (int[] pos in m6)
            {
                Win32.SetCursorPos(pos[0], pos[1]);
                Thread.Sleep(10);
            }
            DoMouseClick();
            Thread.Sleep(256);
            richTextBox1.Text += userNames[ind] + "," + Environment.NewLine;
            ind++;
            nextUsername = userNames[ind];
            cacheClear = (cacheClear + 1) % 5;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void keyWrite(string Text)
        {
            foreach (char let in Text)
            {
                SendKeys.Send(let.ToString());
                Thread.Sleep(50);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);

            foreach (string line in System.IO.File.ReadLines(@"C:\Users\stein\source\repos\Reddit\Reddit\bin\Debug\ActTake.txt"))
            {
                keyWrite(line.Replace(",", ""));
                Thread.Sleep(250);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(800);
            }
        }

        string userFormat(string client_id, string client_secret, string userName)
        {
            return string.Format(@"_{3} = praw.Reddit(client_id={0},
                         client_secret = {1},
                         user_agent = '{2}', 
                         username = '{2}',
                         password = genericPassword)", client_id, client_secret, userName, userName.Replace("-","_"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int usersPyFile = 4;

        private void button3_Click(object sender, EventArgs e)
        {
            int acN = 0;
            string All = "";
            string pathF = @"C:\Users\stein\source\repos\Reddit\Reddit\bin\Debug\myUsers" + usersPyFile + ".py";

            System.IO.File.WriteAllText(pathF, @"import praw
                f = open(r|C:\Users\stein\Desktop\genericPassword.txt|, |r|)
                genericPassword = f.read()
                f.close()

                __client_id = ||
                __client_secret = ||

                class MyUsers" + usersPyFile + @" :


                    def __init__(self, name):
                        self.name = name
                
                ".Replace("|", ((char)34).ToString()));

            foreach (string usr in System.IO.File.ReadLines(@"C:\Users\stein\source\repos\Reddit\Reddit\bin\Debug\Acs_to_Python.txt"))
            {
                System.IO.File.AppendAllText(pathF, Environment.NewLine + userFormat("__client_id", "__client_secret", usr.Replace(",", "")));
                All += "_" + usr.Replace("-","_");
                All = All.Remove(All.Length - 1);
                acN++;
                if (acN == 20)
                {
                    System.IO.File.AppendAllText(pathF, @"
    ### Definitions
    All = [" + All + @"]
    ###");
                    acN = 0;
                    usersPyFile++;
                    All = "";
                    pathF = @"C:\Users\stein\source\repos\Reddit\Reddit\bin\Debug\myUsers" + usersPyFile + ".py";
                    System.IO.File.WriteAllText(pathF, @"import praw
                f = open(r|C:\Users\stein\Desktop\genericPassword.txt|, |r|)
                genericPassword = f.read()
                f.close()

                __client_id = ||
                __client_secret = ||

                class MyUsers" + usersPyFile + @" :


                    def __init__(self, name):
                        self.name = name
                
                ".Replace("|", ((char)34).ToString()));
                }
            }
            System.IO.File.AppendAllText(pathF, @"
                ### Definitions
                All = [" + All + @"]
                ###");
        }
    }
}
