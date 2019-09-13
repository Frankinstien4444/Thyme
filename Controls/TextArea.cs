using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ScintillaNET;
using System.Text.RegularExpressions;
using Thyme.Enums;

namespace Thyme.Controls.ScintillaViewer
{
    class TextArea
    {
        private int latestPos = 0;
        public string Filename = "";
        public bool IstartedCorrectly = false;
        public static RegexOptions SessionOptions = RegexOptions.None;

        private Scintilla _textBox;
        public Scintilla TextBox
        {
            get
            {
                return _textBox;
            }
        }

        public System.Windows.Forms.ToolStripComboBox toolCboRepText;
        public ExportEvents.exportControlEventHandler displayError;

        private Match regMatch = null;
        private Range rangeMatch = null;

        public TextArea()
        {
            try
            {
                // 
                // toolCboRepText
                // 
                this.toolCboRepText = new ToolStripComboBox();
                this.toolCboRepText.Name = "toolCboRepText";
                this.toolCboRepText.Size = new System.Drawing.Size(140, 26);
                // 
                // TextBox
                // 
                this._textBox = new Scintilla();

                this._textBox.Dock = System.Windows.Forms.DockStyle.Fill;
                this._textBox.AllowDrop = true;
                //this._textBox.LineBuffer = ((System.Collections.ArrayList)(resources.GetObject("TextBox.LineBuffer")));
                this._textBox.Location = new System.Drawing.Point(4, 28);
                this._textBox.Name = "TextBox";
                this._textBox.Margins.Margin1.AutoToggleMarkerNumber = 0;
                this._textBox.Margins.Margin1.IsClickable = true;
                this._textBox.Margins.Margin2.Width = 16;
                this._textBox.Lexing.LexerLanguageMap["colorfullsql"] = "colorfullsql";
                this._textBox.ConfigurationManager.CustomLocation = Application.StartupPath + @"\colorfullsql.xml";
                //this._textBox.ConfigurationManager.UseXmlReader = true;
                this._textBox.ConfigurationManager.Language = "mssql";
                this._textBox.ConfigurationManager.Configure();
                this._textBox.LineWrapping.VisualFlags = ScintillaNET.LineWrappingVisualFlags.End;
                this._textBox.Margins.Margin0.Width = 40;
                this._textBox.Folding.IsEnabled = true;
                this._textBox.LineWrapping.Mode = ScintillaNET.LineWrappingMode.Word;
                this._textBox.Indentation.SmartIndentType = SmartIndent.Simple;
                this._textBox.Caret.HighlightCurrentLine = true;
                this._textBox.Selection.BackColorUnfocused = System.Drawing.Color.LightYellow;
                this._textBox.Styles[1].BackColor = System.Drawing.Color.GreenYellow;
                this._textBox.Visible = true;
                this._textBox.Enabled = true;

                //this._textBox.Size = new System.Drawing.Size(530, 206);
                this._textBox.TabIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }
       

        public void mnuSaveFileAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Filename = sfd.FileName;
                mnuSaveFile_Click(sender, e);
            }
        }

        public void mnuSaveFile_Click(object sender, EventArgs e)
        {
            StreamWriter savetheFile = new StreamWriter(Filename);
            savetheFile.Write(TextBox.Text);
            savetheFile.Close();
            savetheFile.Dispose();
        }

        public void toolFindNext_Click(object sender, EventArgs e)
        {
            IstartedCorrectly = true;
            try
            {
                //SearchScintilla(ref this._textBox, SearchMode.Match, toolCboRepText.Text, ref latestPos);
            }
            catch (Exception ex)
            {
                if (displayError != null)
                    displayError(TextBox, new ExportEvents.exportControlEventArgs(ex.Message));
            }
            IstartedCorrectly = false;
        }

        public void toolReset_Click(object sender, EventArgs e)
        {
            latestPos = 0;
            TextBox.FindReplace.ClearAllHighlights();
        }

        public void toolFindAll_Click(object sender, EventArgs e)
        {
            IstartedCorrectly = true;
            try
            {
                //SearchScintilla(ref this._textBox, SearchMode.FindAll, toolCboRepText.Text, ref latestPos);
            }
            catch (Exception ex)
            {
                if (displayError != null)
                    displayError(TextBox, new ExportEvents.exportControlEventArgs(ex.Message));
            }
            IstartedCorrectly = false;
        }

        public void toolReplace_Click(object sender, EventArgs e)
        {
            IstartedCorrectly = true;
             try
            {
            //ReplaceText(ref this._textBox, SearchMode.Replace, toolCboRepText.Text, ref latestPos);
            }
            catch (Exception ex)
            {
                if (displayError != null)
                    displayError(TextBox, new ExportEvents.exportControlEventArgs(ex.Message));
            }
            IstartedCorrectly = false;
        }

        public void toolReplaceAll_Click(object sender, EventArgs e)
        {
            IstartedCorrectly = true;
            try
            {
              //SearchScintilla(ref this._textBox, SearchMode.ReplaceAll, toolCboRepText.Text, ref latestPos);
            }
            catch (Exception ex)
            {
                if (displayError != null)
                    displayError(TextBox, new ExportEvents.exportControlEventArgs(ex.Message));
            }
            IstartedCorrectly = false;
        }

        public void Openfile(Object sender, EventArgs e)
        {
            OpenFileDialog myDiag = new OpenFileDialog();
            myDiag.Title = "Load Text File";
            if (myDiag.ShowDialog() == DialogResult.OK)
            {
                StreamReader fileText = new StreamReader(myDiag.FileName);
                TextBox.Text = fileText.ReadToEnd();
                Filename = myDiag.FileName;
                fileText.Close();
            }
        }

        public void SearchRichTextBox(ref RichTextBox myBox, SearchMode myMode, String replaceText, ref int laststart)
        {
            //if (cboMode.SelectedIndex == 0) return;
            //RichTextBox myBox = (RichTextBox)XmlTextBox;
            //RegularExpressionMonster.SearchMode myMode = new RegularExpressionMonster.SearchMode();
            //myMode = (RegularExpressionMonster.SearchMode)Enum.Parse(myMode.GetType(), cboMode.SelectedItem.ToString());

            switch (myMode)
            {
                case SearchMode.IsaMatch:
                    break;
                case SearchMode.Match:
                case SearchMode.Replace:
                    regMatch = (Match)ExecuteRegEx(ref myBox, SearchMode.Match, replaceText, laststart, 0);
                    if (regMatch.Success)
                    {
                        laststart = regMatch.Index + 1;
                        myBox.SelectionStart = regMatch.Index;
                        myBox.SelectionLength = regMatch.Value.Length;
                        //myBox.SetSelection(regMatch.Index, regMatch.Index + regMatch.Value.Length);
                        myBox.ScrollToCaret();
                        myBox.Focus();

                    }
                    break;

                case SearchMode.FindAll:

                    break;

                case SearchMode.Matches:
                    break;

                case SearchMode.ReplaceAll:
                    String result = ExecuteRegEx(ref myBox, SearchMode.ReplaceAll, replaceText, laststart, 0).ToString();
                    MessageBox.Show("All text matching regular expression have been replaced");
                    myBox.Text = result;

                    break;
            }
        }

        public void SearchScintilla(ref TextBox searchBox, SearchMode myMode, String replaceText, ref int laststart)
        {
            String regExString = searchBox.Text;
            if (searchBox.SelectedText != null && searchBox.SelectedText.Length != 0)
                regExString = searchBox.SelectedText;

            Regex Expressions = new Regex(regExString, SessionOptions);
            switch (myMode)
            {
                case SearchMode.IsaMatch:
                    break;
                case SearchMode.Match:
                case SearchMode.Replace:
                    rangeMatch = _textBox.FindReplace.Find(laststart, _textBox.Text.Length - 1, Expressions);
                    //(Match)ExecuteRegEx(ref myBox, RegularExpressionMonster.SearchMode.Match, replaceText, laststart, 0);
                    if (rangeMatch != null)
                    {
                        rangeMatch.Select();
                        laststart = rangeMatch.End;
                        _textBox.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No Occurances Found");
                    }
                    break;

                case SearchMode.FindAll:
                    List<Range> resultsOf = _textBox.FindReplace.FindAll(Expressions);
                    if (resultsOf != null && resultsOf.Count > 0)
                    {
                        foreach (Range hl in resultsOf)
                            hl.SetStyle(1);
                        _textBox.FindReplace.HighlightAll(resultsOf);
                    }
                    else
                        MessageBox.Show("No results found.");
                    break;


                case SearchMode.Matches:
                    break;

                case SearchMode.ReplaceAll:
                    //String result = ExecuteRegEx(ref myBox, RegularExpressionMonster.SearchMode.ReplaceAll, replaceText, laststart, 0).ToString();
                    _textBox.FindReplace.ReplaceAll(Expressions, replaceText);
                    MessageBox.Show("All text matching regular expression have been replaced");
                    //myBox.Text = result;

                    break;
            }
        }

        public void ReplaceText(ref RichTextBox myBox, SearchMode myMode, String replaceText, ref int laststart)
        {
            if (regMatch.Success)
            {

                String result = ExecuteRegEx(ref myBox, SearchMode.Replace, replaceText, regMatch.Index, 0).ToString();
                myBox.Text = result;
                SearchRichTextBox(ref myBox, myMode, replaceText, ref laststart);
            }
        }

        public void ReplaceText(SearchMode myMode, String replaceText, ref int laststart)
        {
            if (rangeMatch != null)
            {
                _textBox.FindReplace.ReplacePrevious(rangeMatch.Text, replaceText);
                rangeMatch = null;
                //String result = ExecuteRegEx(ref myBox, RegularExpressionMonster.SearchMode.Replace, replaceText, regMatch.Index, 0).ToString();
                //myBox.Text = result;
                //SearchScintilla( myMode, replaceText, ref laststart);
            }
        }

        public Object ExecuteRegEx(ref RichTextBox rText, SearchMode mode, String replaceText, int startat, int lgth)
        {
            Object Result = null;
            Regex Expressions = new Regex("", SessionOptions);

            switch (mode)
            {
                case SearchMode.IsaMatch:
                    Result = Expressions.IsMatch(rText.Text, startat);
                    break;

                case SearchMode.Match:
                    if (lgth > 0)
                        Result = Expressions.Match(rText.Text, startat, lgth);
                    else
                        Result = Expressions.Match(rText.Text, startat);
                    break;

                case SearchMode.Matches:
                    Result = Expressions.Matches(rText.Text, startat);
                    break;

                case SearchMode.Replace:
                    Result = Expressions.Replace(rText.Text, replaceText, 1);
                    break;

                case SearchMode.ReplaceAll:
                    Result = Expressions.Replace(rText.Text, replaceText);
                    break;

                case SearchMode.Split:
                    Result = Expressions.Split(rText.Text);
                    break;
            }
            return Result;
        }

    }
}
