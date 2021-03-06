﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace FormsAppTest
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.25463.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1 - Use 'RecordedMethod1Params' to pass parameters into this method.
        /// </summary>
        public void FillTextFields()
        {
            #region Variable Declarations
            WinEdit uITextFirstNameEdit = this.UIFillRegistrationDetaWindow.UITextFirstNameWindow.UITextFirstNameEdit;
            WinEdit uITextLastNameEdit = this.UIFillRegistrationDetaWindow.UITextLastNameWindow.UITextLastNameEdit;
            WinComboBox uIGenderComboBox = this.UIFillRegistrationDetaWindow.UICmbGenderWindow.UIGenderComboBox;
            WinEdit uITextAddressEdit = this.UIFillRegistrationDetaWindow.UITextAddressWindow.UITextAddressEdit;
            WinCheckBox uIIndiaCheckBox = this.UIFillRegistrationDetaWindow.UIIndiaWindow.UIIndiaCheckBox;
            WinButton uIOKButton = this.UIFillRegistrationDetaWindow.UIOKWindow.UIOKButton;
            #endregion

            // Type 'Sanoop' in 'textFirstName' text box
            uITextFirstNameEdit.Text = this.RecordedMethod1Params.UITextFirstNameEditText;

            // Type 'Ak' in 'textLastName' text box
            uITextLastNameEdit.Text = this.RecordedMethod1Params.UITextLastNameEditText;

            // Select 'Male' in 'Gender' combo box
            uIGenderComboBox.SelectedItem = this.RecordedMethod1Params.UIGenderComboBoxSelectedItem;

            // Type the following paragraph in 'textAddress' text box 
            //'SE-Mentor
            //Gayatri Building
            //Technopark'
            uITextAddressEdit.Text = this.RecordedMethod1Params.UITextAddressEditText;

            // Select 'India' check box
            uIIndiaCheckBox.Checked = this.RecordedMethod1Params.UIIndiaCheckBoxChecked;

            Playback.Wait(2000);
            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(47, 21));
        }
        
        /// <summary>
        /// AssertIfLogoIsPresentOrNot - Use 'AssertIfLogoIsPresentOrNotExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertIfLogoIsPresentOrNot()
        {
            #region Variable Declarations
            WinClient uIPictureBoxLogoClient = this.UIFillRegistrationDetaWindow.UIPictureBoxLogoWindow.UIPictureBoxLogoClient;
            #endregion

            // Verify that the 'ControlType' property of 'pictureBoxLogo' client contains 'Client'
            StringAssert.Contains(uIPictureBoxLogoClient.ControlType.ToString(), this.AssertIfLogoIsPresentOrNotExpectedValues.UIPictureBoxLogoClientControlType, "Assertion Failed as Logo is not present");
            uIPictureBoxLogoClient.DrawHighlight();
        }
        
        /// <summary>
        /// CheckBoxSelectedOrNot - Use 'CheckBoxSelectedOrNotParams' to pass parameters into this method.
        /// </summary>
        public void AssertUKCheckBoxSelectedOrNot()
        {
            #region Variable Declarations
            WinCheckBox uIUnitedKingdomCheckBox = this.UIFillRegistrationDetaWindow.UIUnitedKingdomWindow.UIUnitedKingdomCheckBox;
            #endregion

            Assert.AreEqual(uIUnitedKingdomCheckBox.GetProperty("Name").ToString(), "UK");
        }

        public void CheckBoxUKSelect()
        {
            #region Variable Declarations
            WinCheckBox uIUnitedKingdomCheckBox = this.UIFillRegistrationDetaWindow.UIUnitedKingdomWindow.UIUnitedKingdomCheckBox;
            WinButton uIOKButton = this.UIFillRegistrationDetaWindow.UIOKWindow.UIOKButton;
            #endregion

            // Select 'United Kingdom' check box
            uIUnitedKingdomCheckBox.Checked = this.CheckBoxSelectedOrNotParams.UIUnitedKingdomCheckBoxChecked;

            // Click 'OK' button
            Mouse.Click(uIOKButton);
        }

        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public virtual AssertIfLogoIsPresentOrNotExpectedValues AssertIfLogoIsPresentOrNotExpectedValues
        {
            get
            {
                if ((this.mAssertIfLogoIsPresentOrNotExpectedValues == null))
                {
                    this.mAssertIfLogoIsPresentOrNotExpectedValues = new AssertIfLogoIsPresentOrNotExpectedValues();
                }
                return this.mAssertIfLogoIsPresentOrNotExpectedValues;
            }
        }
        
        public virtual CheckBoxSelectedOrNotParams CheckBoxSelectedOrNotParams
        {
            get
            {
                if ((this.mCheckBoxSelectedOrNotParams == null))
                {
                    this.mCheckBoxSelectedOrNotParams = new CheckBoxSelectedOrNotParams();
                }
                return this.mCheckBoxSelectedOrNotParams;
            }
        }
        
        public UIFillRegistrationDetaWindow UIFillRegistrationDetaWindow
        {
            get
            {
                if ((this.mUIFillRegistrationDetaWindow == null))
                {
                    this.mUIFillRegistrationDetaWindow = new UIFillRegistrationDetaWindow();
                }
                return this.mUIFillRegistrationDetaWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private AssertIfLogoIsPresentOrNotExpectedValues mAssertIfLogoIsPresentOrNotExpectedValues;
        
        private CheckBoxSelectedOrNotParams mCheckBoxSelectedOrNotParams;
        
        private UIFillRegistrationDetaWindow mUIFillRegistrationDetaWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.25463.0")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Type 'Sanoop' in 'textFirstName' text box
        /// </summary>
        public string UITextFirstNameEditText = TestData.FirstName;
        
        /// <summary>
        /// Type 'Ak' in 'textLastName' text box
        /// </summary>
        public string UITextLastNameEditText = TestData.LastName;

        /// <summary>
        /// Select 'Male' in 'Gender' combo box
        /// </summary>
        public string UIGenderComboBoxSelectedItem = TestData.Gender;
        
        /// <summary>
        /// Type the following paragraph in 'textAddress' text box 
        ///'SE-Mentor
        ///Gayatri Building
        ///Technopark'
        /// </summary>
        public string UITextAddressEditText = TestData.Address;
        
        /// <summary>
        /// Select 'India' check box
        /// </summary>
        public bool UIIndiaCheckBoxChecked = true;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertIfLogoIsPresentOrNot'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.25463.0")]
    public class AssertIfLogoIsPresentOrNotExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'ControlType' property of 'pictureBoxLogo' client contains 'Client'
        /// </summary>
        public string UIPictureBoxLogoClientControlType = "Client";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'CheckBoxSelectedOrNot'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.25463.0")]
    public class CheckBoxSelectedOrNotParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'United Kingdom' check box
        /// </summary>
        public bool UIUnitedKingdomCheckBoxChecked = true;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.25463.0")]
    public class UIFillRegistrationDetaWindow : WinWindow
    {
        
        public UIFillRegistrationDetaWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "FillRegistrationDetails";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("FillRegistrationDetails");
            #endregion
        }
        
        #region Properties
        public UITextFirstNameWindow UITextFirstNameWindow
        {
            get
            {
                if ((this.mUITextFirstNameWindow == null))
                {
                    this.mUITextFirstNameWindow = new UITextFirstNameWindow(this);
                }
                return this.mUITextFirstNameWindow;
            }
        }
        
        public UITextLastNameWindow UITextLastNameWindow
        {
            get
            {
                if ((this.mUITextLastNameWindow == null))
                {
                    this.mUITextLastNameWindow = new UITextLastNameWindow(this);
                }
                return this.mUITextLastNameWindow;
            }
        }
        
        public UICmbGenderWindow UICmbGenderWindow
        {
            get
            {
                if ((this.mUICmbGenderWindow == null))
                {
                    this.mUICmbGenderWindow = new UICmbGenderWindow(this);
                }
                return this.mUICmbGenderWindow;
            }
        }
        
        public UITextAddressWindow UITextAddressWindow
        {
            get
            {
                if ((this.mUITextAddressWindow == null))
                {
                    this.mUITextAddressWindow = new UITextAddressWindow(this);
                }
                return this.mUITextAddressWindow;
            }
        }
        
        public UIIndiaWindow UIIndiaWindow
        {
            get
            {
                if ((this.mUIIndiaWindow == null))
                {
                    this.mUIIndiaWindow = new UIIndiaWindow(this);
                }
                return this.mUIIndiaWindow;
            }
        }
        
        public UIOKWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow(this);
                }
                return this.mUIOKWindow;
            }
        }
        
        public UIPictureBoxLogoWindow UIPictureBoxLogoWindow
        {
            get
            {
                if ((this.mUIPictureBoxLogoWindow == null))
                {
                    this.mUIPictureBoxLogoWindow = new UIPictureBoxLogoWindow(this);
                }
                return this.mUIPictureBoxLogoWindow;
            }
        }
        
        public UIUnitedKingdomWindow UIUnitedKingdomWindow
        {
            get
            {
                if ((this.mUIUnitedKingdomWindow == null))
                {
                    this.mUIUnitedKingdomWindow = new UIUnitedKingdomWindow(this);
                }
                return this.mUIUnitedKingdomWindow;
            }
        }
        #endregion
        
        #region Fields
        private UITextFirstNameWindow mUITextFirstNameWindow;
        
        private UITextLastNameWindow mUITextLastNameWindow;
        
        private UICmbGenderWindow mUICmbGenderWindow;
        
        private UITextAddressWindow mUITextAddressWindow;
        
        private UIIndiaWindow mUIIndiaWindow;
        
        private UIOKWindow mUIOKWindow;
        
        private UIPictureBoxLogoWindow mUIPictureBoxLogoWindow;
        
        private UIUnitedKingdomWindow mUIUnitedKingdomWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.25463.0")]
    public class UITextFirstNameWindow : WinWindow
    {
        
        public UITextFirstNameWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "textFirstName";
            this.WindowTitles.Add("FillRegistrationDetails");
            #endregion
        }
        
        #region Properties
        public WinEdit UITextFirstNameEdit
        {
            get
            {
                if ((this.mUITextFirstNameEdit == null))
                {
                    this.mUITextFirstNameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITextFirstNameEdit.WindowTitles.Add("FillRegistrationDetails");
                    #endregion
                }
                return this.mUITextFirstNameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITextFirstNameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.25463.0")]
    public class UITextLastNameWindow : WinWindow
    {
        
        public UITextLastNameWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "textLastName";
            this.WindowTitles.Add("FillRegistrationDetails");
            #endregion
        }
        
        #region Properties
        public WinEdit UITextLastNameEdit
        {
            get
            {
                if ((this.mUITextLastNameEdit == null))
                {
                    this.mUITextLastNameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITextLastNameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "First Name";
                    this.mUITextLastNameEdit.WindowTitles.Add("FillRegistrationDetails");
                    #endregion
                }
                return this.mUITextLastNameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITextLastNameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.25463.0")]
    public class UICmbGenderWindow : WinWindow
    {
        
        public UICmbGenderWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "cmbGender";
            this.WindowTitles.Add("FillRegistrationDetails");
            #endregion
        }
        
        #region Properties
        public WinComboBox UIGenderComboBox
        {
            get
            {
                if ((this.mUIGenderComboBox == null))
                {
                    this.mUIGenderComboBox = new WinComboBox(this);
                    #region Search Criteria
                    this.mUIGenderComboBox.SearchProperties[WinComboBox.PropertyNames.Name] = "Gender";
                    this.mUIGenderComboBox.WindowTitles.Add("FillRegistrationDetails");
                    #endregion
                }
                return this.mUIGenderComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinComboBox mUIGenderComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.25463.0")]
    public class UITextAddressWindow : WinWindow
    {
        
        public UITextAddressWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "textAddress";
            this.WindowTitles.Add("FillRegistrationDetails");
            #endregion
        }
        
        #region Properties
        public WinEdit UITextAddressEdit
        {
            get
            {
                if ((this.mUITextAddressEdit == null))
                {
                    this.mUITextAddressEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITextAddressEdit.WindowTitles.Add("FillRegistrationDetails");
                    #endregion
                }
                return this.mUITextAddressEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITextAddressEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.25463.0")]
    public class UIIndiaWindow : WinWindow
    {
        
        public UIIndiaWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "chkIndia";
            this.WindowTitles.Add("FillRegistrationDetails");
            #endregion
        }
        
        #region Properties
        public WinCheckBox UIIndiaCheckBox
        {
            get
            {
                if ((this.mUIIndiaCheckBox == null))
                {
                    this.mUIIndiaCheckBox = new WinCheckBox(this);
                    #region Search Criteria
                    this.mUIIndiaCheckBox.SearchProperties[WinCheckBox.PropertyNames.Name] = "India";
                    this.mUIIndiaCheckBox.WindowTitles.Add("FillRegistrationDetails");
                    #endregion
                }
                return this.mUIIndiaCheckBox;
            }
        }
        #endregion
        
        #region Fields
        private WinCheckBox mUIIndiaCheckBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.25463.0")]
    public class UIOKWindow : WinWindow
    {
        
        public UIOKWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnOk";
            this.WindowTitles.Add("FillRegistrationDetails");
            #endregion
        }
        
        #region Properties
        public WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIOKButton.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                    this.mUIOKButton.WindowTitles.Add("FillRegistrationDetails");
                    #endregion
                }
                return this.mUIOKButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIOKButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.25463.0")]
    public class UIPictureBoxLogoWindow : WinWindow
    {
        
        public UIPictureBoxLogoWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "pictureBoxLogo";
            this.WindowTitles.Add("FillRegistrationDetails");
            #endregion
        }
        
        #region Properties
        public WinClient UIPictureBoxLogoClient
        {
            get
            {
                if ((this.mUIPictureBoxLogoClient == null))
                {
                    this.mUIPictureBoxLogoClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIPictureBoxLogoClient.WindowTitles.Add("FillRegistrationDetails");
                    #endregion
                }
                return this.mUIPictureBoxLogoClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIPictureBoxLogoClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.25463.0")]
    public class UIUnitedKingdomWindow : WinWindow
    {
        
        public UIUnitedKingdomWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "chkUk";
            this.WindowTitles.Add("FillRegistrationDetails");
            #endregion
        }
        
        #region Properties
        public WinCheckBox UIUnitedKingdomCheckBox
        {
            get
            {
                if ((this.mUIUnitedKingdomCheckBox == null))
                {
                    this.mUIUnitedKingdomCheckBox = new WinCheckBox(this);
                    #region Search Criteria
                    this.mUIUnitedKingdomCheckBox.SearchProperties[WinCheckBox.PropertyNames.Name] = "United Kingdom";
                    this.mUIUnitedKingdomCheckBox.WindowTitles.Add("FillRegistrationDetails");
                    #endregion
                }
                return this.mUIUnitedKingdomCheckBox;
            }
        }
        #endregion
        
        #region Fields
        private WinCheckBox mUIUnitedKingdomCheckBox;
        #endregion
    }
}
