﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod
        /// </summary>
        public void RecordedMethod()
        {
            #region Variable Declarations
            WpfButton uIHidudeDButton = this.UIMainWindowWindow.UIHidudeDButton;
            #endregion

            // Click 'Hi, dude! :D' button
            Mouse.Click(uIHidudeDButton, new Point(276, 104));
        }
        
        /// <summary>
        /// RecordedMethod1
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WpfButton uIHidudeDButton = this.UIMainWindowWindow.UIHidudeDButton;
            #endregion

            // Click 'Hi, dude! :D' button
            Mouse.Click(uIHidudeDButton, new Point(232, 73));
        }
        
        /// <summary>
        /// RecordedMethod2
        /// </summary>
        public void RecordedMethod2()
        {
            #region Variable Declarations
            WpfButton uIHidudeDButton = this.UIMainWindowWindow.UIHidudeDButton;
            #endregion

            // Click 'Hi, dude! :D' button
            Mouse.Click(uIHidudeDButton, new Point(330, 56));
        }
        
        /// <summary>
        /// AssertMethod1 - Use 'AssertMethod1ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod1()
        {
            #region Variable Declarations
            WpfEdit uITextBox1Edit = this.UIMainWindowWindow.UITextBox1Edit;
            #endregion

            // Verify that the 'AutomationId' property of 'TextBox1' text box equals 'Hi, dude! :D'
            Assert.AreEqual(this.AssertMethod1ExpectedValues.UITextBox1EditAutomationId, uITextBox1Edit.AutomationId, "FAILED>F>F>");
        }
        
        /// <summary>
        /// RecordedMethod3
        /// </summary>
        public void RecordedMethod3()
        {
            #region Variable Declarations
            WpfButton uIHidudeDButton = this.UIMainWindowWindow.UIHidudeDButton;
            #endregion

            // Click 'Hi, dude! :D' button
            Mouse.Click(uIHidudeDButton, new Point(275, 122));
        }
        
        /// <summary>
        /// AssertMethod2 - Use 'AssertMethod2ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod2()
        {
            #region Variable Declarations
            WpfEdit uITextBox1Edit = this.UIMainWindowWindow.UITextBox1Edit;
            #endregion

            // Verify that the 'Text' property of 'TextBox1' text box equals 'Hi, dude! :D'
            Assert.AreEqual(this.AssertMethod2ExpectedValues.UITextBox1EditText, uITextBox1Edit.Text);
        }
        
        #region Properties
        public virtual AssertMethod1ExpectedValues AssertMethod1ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod1ExpectedValues == null))
                {
                    this.mAssertMethod1ExpectedValues = new AssertMethod1ExpectedValues();
                }
                return this.mAssertMethod1ExpectedValues;
            }
        }
        
        public virtual AssertMethod2ExpectedValues AssertMethod2ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod2ExpectedValues == null))
                {
                    this.mAssertMethod2ExpectedValues = new AssertMethod2ExpectedValues();
                }
                return this.mAssertMethod2ExpectedValues;
            }
        }
        
        public UIMainWindowWindow UIMainWindowWindow
        {
            get
            {
                if ((this.mUIMainWindowWindow == null))
                {
                    this.mUIMainWindowWindow = new UIMainWindowWindow();
                }
                return this.mUIMainWindowWindow;
            }
        }
        #endregion
        
        #region Fields
        private AssertMethod1ExpectedValues mAssertMethod1ExpectedValues;
        
        private AssertMethod2ExpectedValues mAssertMethod2ExpectedValues;
        
        private UIMainWindowWindow mUIMainWindowWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class AssertMethod1ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'AutomationId' property of 'TextBox1' text box equals 'Hi, dude! :D'
        /// </summary>
        public string UITextBox1EditAutomationId = "Hi, dude! :D";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod2'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class AssertMethod2ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Text' property of 'TextBox1' text box equals 'Hi, dude! :D'
        /// </summary>
        public string UITextBox1EditText = "Hi, dude! :D";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIMainWindowWindow : WpfWindow
    {
        
        public UIMainWindowWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "MainWindow";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public WpfButton UIHidudeDButton
        {
            get
            {
                if ((this.mUIHidudeDButton == null))
                {
                    this.mUIHidudeDButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIHidudeDButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "Button1";
                    this.mUIHidudeDButton.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUIHidudeDButton;
            }
        }
        
        public WpfEdit UITextBox1Edit
        {
            get
            {
                if ((this.mUITextBox1Edit == null))
                {
                    this.mUITextBox1Edit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUITextBox1Edit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "TextBox1";
                    this.mUITextBox1Edit.WindowTitles.Add("MainWindow");
                    #endregion
                }
                return this.mUITextBox1Edit;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUIHidudeDButton;
        
        private WpfEdit mUITextBox1Edit;
        #endregion
    }
}
