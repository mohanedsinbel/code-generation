using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace CaptchaGenerator
{
    public partial class Form1 : Form
    {
        private string currentTextCaptcha;
        private int currentMathCaptchaAnswer;
        private bool imageCaptchaVerified = false;
        private List<Rectangle> trafficLightRectangles = new List<Rectangle>();
        private List<Rectangle> selectedSquares = new List<Rectangle>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateTextCaptcha();
            GenerateMathCaptcha();
            GenerateImageCaptcha();
        }

        private void GenerateTextCaptcha()
        {
            // Generate random text with distortion
            Random random = new Random();
            string chars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghjkmnpqrstuvwxyz23456789";
            currentTextCaptcha = "";

            for (int i = 0; i < 6; i++)
            {
                currentTextCaptcha += chars[random.Next(chars.Length)];
            }

            // Display the CAPTCHA with some styling
            textCaptchaLabel.Text = currentTextCaptcha;
            textCaptchaLabel.Font = new Font("Arial", 18, FontStyle.Bold);
            textCaptchaLabel.ForeColor = Color.FromArgb(random.Next(100, 200), random.Next(100, 200), random.Next(100, 200));
        }

        private void GenerateMathCaptcha()
        {
            Random random = new Random();
            int num1 = random.Next(1, 10);
            int num2 = random.Next(1, 10);
            currentMathCaptchaAnswer = num1 + num2;

            mathCaptchaLabel.Text = $"{num1} + {num2} = ?";
        }

        private void GenerateImageCaptcha()
        {
            // Create a 3x3 grid of squares
            Bitmap bmp = new Bitmap(450, 350);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                trafficLightRectangles.Clear();
                selectedSquares.Clear();

                // Draw 3x3 grid
                int squareSize = 150;
                for (int row = 0; row < 2; row++) // Changed to 2 rows for better display
                {
                    for (int col = 0; col < 3; col++)
                    {
                        Rectangle rect = new Rectangle(col * squareSize, row * squareSize, squareSize, squareSize);
                        g.DrawRectangle(Pens.LightGray, rect);

                        // Randomly decide if this square contains traffic lights (about 50% chance)
                        if (new Random().Next(2) == 1)
                        {
                            DrawTrafficLights(g, rect);
                            trafficLightRectangles.Add(rect);
                        }
                    }
                }
            }

            imageCaptchaDisplay.Image = bmp;
            imageCaptchaDisplay.Cursor = Cursors.Hand;
            UpdateSelectionCount();
            imageCaptchaVerified = false;
        }

        private void DrawTrafficLights(Graphics g, Rectangle rect)
        {
            int lightSize = 30;
            int x = rect.X + rect.Width / 2 - lightSize / 2;
            int y = rect.Y + 20;

            // Draw pole
            g.FillRectangle(Brushes.Gray, x + lightSize / 2 - 5, y + lightSize * 3, 10, rect.Height - 20 - lightSize * 3);

            // Draw lights
            g.FillEllipse(Brushes.Red, x, y, lightSize, lightSize);
            g.FillEllipse(Brushes.Yellow, x, y + lightSize + 10, lightSize, lightSize);
            g.FillEllipse(Brushes.Green, x, y + (lightSize + 10) * 2, lightSize, lightSize);
        }

        private void ImageCaptchaDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            // Determine which square was clicked
            int squareSize = 150;
            int col = e.X / squareSize;
            int row = e.Y / squareSize;

            if (col >= 0 && col < 3 && row >= 0 && row < 2) // Adjusted for 2 rows
            {
                Rectangle clickedRect = new Rectangle(col * squareSize, row * squareSize, squareSize, squareSize);

                // Toggle selection
                if (selectedSquares.Contains(clickedRect))
                {
                    selectedSquares.Remove(clickedRect);
                }
                else
                {
                    selectedSquares.Add(clickedRect);
                }

                // Redraw with selections
                RedrawImageCaptcha();
                UpdateSelectionCount();
            }
        }

        private void RedrawImageCaptcha()
        {
            Bitmap bmp = new Bitmap(450, 350);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                // Draw grid
                int squareSize = 150;
                for (int row = 0; row < 2; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        Rectangle rect = new Rectangle(col * squareSize, row * squareSize, squareSize, squareSize);
                        g.DrawRectangle(Pens.LightGray, rect);
                    }
                }

                // Redraw traffic lights
                foreach (Rectangle rect in trafficLightRectangles)
                {
                    DrawTrafficLights(g, rect);
                }

                // Highlight selected squares
                foreach (Rectangle rect in selectedSquares)
                {
                    using (Brush highlight = new SolidBrush(Color.FromArgb(50, 0, 0, 255)))
                    {
                        g.FillRectangle(highlight, rect);
                    }
                    g.DrawRectangle(Pens.Blue, rect);
                }
            }

            imageCaptchaDisplay.Image = bmp;
        }

        private void UpdateSelectionCount()
        {
            label4.Text = $"Selected: {selectedSquares.Count} squares";
        }

        private void imageCaptchaSubmit_Click(object sender, EventArgs e)
        {
            // Verify that all traffic light squares are selected and no extra squares are selected
            bool allCorrect = true;

            // Check all traffic light squares are selected
            foreach (Rectangle trafficLightRect in trafficLightRectangles)
            {
                if (!selectedSquares.Contains(trafficLightRect))
                {
                    allCorrect = false;
                    break;
                }
            }

            // Check no extra squares are selected
            if (allCorrect)
            {
                foreach (Rectangle selectedRect in selectedSquares)
                {
                    if (!trafficLightRectangles.Contains(selectedRect))
                    {
                        allCorrect = false;
                        break;
                    }
                }
            }

            if (allCorrect && trafficLightRectangles.Count > 0)
            {
                resultLabel.Text = "Success! Image CAPTCHA verified.";
                resultLabel.ForeColor = Color.Green;
                imageCaptchaVerified = true;
            }
            else
            {
                resultLabel.Text = "Error! Please select ONLY squares with traffic lights.";
                resultLabel.ForeColor = Color.Red;
                imageCaptchaVerified = false;
            }
        }

        private void textCaptchaRefresh_Click(object sender, EventArgs e)
        {
            GenerateTextCaptcha();
            textCaptchaInput.Text = "";
            resultLabel.Text = "";
        }

        private void textCaptchaSubmit_Click(object sender, EventArgs e)
        {
            if (textCaptchaInput.Text.Equals(currentTextCaptcha, StringComparison.OrdinalIgnoreCase))
            {
                resultLabel.Text = "Success! Text CAPTCHA verified.";
                resultLabel.ForeColor = Color.Green;
            }
            else
            {
                resultLabel.Text = "Error! Text doesn't match. Try again.";
                resultLabel.ForeColor = Color.Red;
            }
        }

        private void imageCaptchaRefresh_Click(object sender, EventArgs e)
        {
            GenerateImageCaptcha();
            resultLabel.Text = "";
        }

        private void mathCaptchaRefresh_Click(object sender, EventArgs e)
        {
            GenerateMathCaptcha();
            mathCaptchaInput.Text = "";
            resultLabel.Text = "";
        }

        private void mathCaptchaSubmit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(mathCaptchaInput.Text, out int userAnswer) && userAnswer == currentMathCaptchaAnswer)
            {
                resultLabel.Text = "Success! Math CAPTCHA verified.";
                resultLabel.ForeColor = Color.Green;
            }
            else
            {
                resultLabel.Text = "Error! Incorrect answer. Try again.";
                resultLabel.ForeColor = Color.Red;
            }
        }

        private void recaptchaRefresh_Click(object sender, EventArgs e)
        {
            recaptchaCheckbox.Checked = false;
            resultLabel.Text = "";
        }

        private void recaptchaSubmit_Click(object sender, EventArgs e)
        {
            if (recaptchaCheckbox.Checked)
            {
                resultLabel.Text = "Success! reCAPTCHA verified.";
                resultLabel.ForeColor = Color.Green;
            }
            else
            {
                resultLabel.Text = "Error! Please check the reCAPTCHA box.";
                resultLabel.ForeColor = Color.Red;
            }
        }
    }
}