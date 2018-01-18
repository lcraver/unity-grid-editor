using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

[System.Serializable]
public class LSInput
{

    public bool activeOnGUIFocus = false;
    public static bool GUIActive = false;

    /// <summary>
    /// Contains all the data for a keyboard.
    /// </summary>
    [System.Serializable]
    public class Keyboard
    {
        public bool active;

        public bool getAnyKey() { return UnityEngine.Input.anyKey && GUIActive == false; }
        public bool getAnyKeyDown() { return UnityEngine.Input.anyKeyDown && GUIActive == false; }

        public bool getEscape() { return UnityEngine.Input.GetKey(KeyCode.Escape) && GUIActive == false; }
        public bool getEscapeDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Escape) && GUIActive == false; }
        public bool getEscapeUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Escape) && GUIActive == false; }

        public bool getBackquote() { return UnityEngine.Input.GetKey(KeyCode.BackQuote) && GUIActive == false; }
        public bool getBackquoteDown() { return UnityEngine.Input.GetKeyDown(KeyCode.BackQuote) && GUIActive == false; }
        public bool getBackquoteUp() { return UnityEngine.Input.GetKeyUp(KeyCode.BackQuote) && GUIActive == false; }

        public bool getAlpha1() { return UnityEngine.Input.GetKey(KeyCode.Alpha1) && GUIActive == false; }
        public bool getAlpha1Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha1) && GUIActive == false; }
        public bool getAlpha1Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha1) && GUIActive == false; }

        public bool getAlpha2() { return UnityEngine.Input.GetKey(KeyCode.Alpha2) && GUIActive == false; }
        public bool getAlpha2Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha2) && GUIActive == false; }
        public bool getAlpha2Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha2) && GUIActive == false; }

        public bool getAlpha3() { return UnityEngine.Input.GetKey(KeyCode.Alpha3) && GUIActive == false; }
        public bool getAlpha3Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha3) && GUIActive == false; }
        public bool getAlpha3Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha3) && GUIActive == false; }

        public bool getAlpha4() { return UnityEngine.Input.GetKey(KeyCode.Alpha4) && GUIActive == false; }
        public bool getAlpha4Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha4) && GUIActive == false; }
        public bool getAlpha4Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha4) && GUIActive == false; }

        public bool getAlpha5() { return UnityEngine.Input.GetKey(KeyCode.Alpha5) && GUIActive == false; }
        public bool getAlpha5Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha5) && GUIActive == false; }
        public bool getAlpha5Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha5) && GUIActive == false; }

        public bool getAlpha6() { return UnityEngine.Input.GetKey(KeyCode.Alpha6) && GUIActive == false; }
        public bool getAlpha6Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha6) && GUIActive == false; }
        public bool getAlpha6Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha6) && GUIActive == false; }

        public bool getAlpha7() { return UnityEngine.Input.GetKey(KeyCode.Alpha7) && GUIActive == false; }
        public bool getAlpha7Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha7) && GUIActive == false; }
        public bool getAlpha7Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha7) && GUIActive == false; }

        public bool getAlpha8() { return UnityEngine.Input.GetKey(KeyCode.Alpha8) && GUIActive == false; }
        public bool getAlpha8Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha8) && GUIActive == false; }
        public bool getAlpha8Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha8) && GUIActive == false; }

        public bool getAlpha9() { return UnityEngine.Input.GetKey(KeyCode.Alpha9) && GUIActive == false; }
        public bool getAlpha9Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha9) && GUIActive == false; }
        public bool getAlpha9Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha9) && GUIActive == false; }

        public bool getAlpha0() { return UnityEngine.Input.GetKey(KeyCode.Alpha0) && GUIActive == false; }
        public bool getAlpha0Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Alpha0) && GUIActive == false; }
        public bool getAlpha0Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Alpha0) && GUIActive == false; }

        public bool getMinus() { return UnityEngine.Input.GetKey(KeyCode.Minus) && GUIActive == false; }
        public bool getMinusDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Minus) && GUIActive == false; }
        public bool getMinusUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Minus) && GUIActive == false; }

        public bool getEquals() { return UnityEngine.Input.GetKey(KeyCode.Equals) && GUIActive == false; }
        public bool getEqualsDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Equals) && GUIActive == false; }
        public bool getEqualsUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Equals) && GUIActive == false; }

        public bool getBackspace() { return UnityEngine.Input.GetKey(KeyCode.Backspace) && GUIActive == false; }
        public bool getBackspaceDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Backspace) && GUIActive == false; }
        public bool getBackspaceUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Backspace) && GUIActive == false; }

        //

        public bool getTab() { return UnityEngine.Input.GetKey(KeyCode.Tab) && GUIActive == false; }
        public bool getTabDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Tab) && GUIActive == false; }
        public bool getTabUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Tab) && GUIActive == false; }

        public bool getQ() { return UnityEngine.Input.GetKey(KeyCode.Q) && GUIActive == false; }
        public bool getQDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Q) && GUIActive == false; }
        public bool getQUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Q) && GUIActive == false; }

        public bool getW() { return UnityEngine.Input.GetKey(KeyCode.W) && GUIActive == false; }
        public bool getWDown() { return UnityEngine.Input.GetKeyDown(KeyCode.W) && GUIActive == false; }
        public bool getWUp() { return UnityEngine.Input.GetKeyUp(KeyCode.W) && GUIActive == false; }

        public bool getE() { return UnityEngine.Input.GetKey(KeyCode.E) && GUIActive == false; }
        public bool getEDown() { return UnityEngine.Input.GetKeyDown(KeyCode.E) && GUIActive == false; }
        public bool getEUp() { return UnityEngine.Input.GetKeyUp(KeyCode.E) && GUIActive == false; }

        public bool getR() { return UnityEngine.Input.GetKey(KeyCode.R) && GUIActive == false; }
        public bool getRDown() { return UnityEngine.Input.GetKeyDown(KeyCode.R) && GUIActive == false; }
        public bool getRUp() { return UnityEngine.Input.GetKeyUp(KeyCode.R) && GUIActive == false; }

        public bool getT() { return UnityEngine.Input.GetKey(KeyCode.T) && GUIActive == false; }
        public bool getTDown() { return UnityEngine.Input.GetKeyDown(KeyCode.T) && GUIActive == false; }
        public bool getTUp() { return UnityEngine.Input.GetKeyUp(KeyCode.T) && GUIActive == false; }

        public bool getY() { return UnityEngine.Input.GetKey(KeyCode.Y) && GUIActive == false; }
        public bool getYDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Y) && GUIActive == false; }
        public bool getYUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Y) && GUIActive == false; }

        public bool getU() { return UnityEngine.Input.GetKey(KeyCode.U) && GUIActive == false; }
        public bool getUDown() { return UnityEngine.Input.GetKeyDown(KeyCode.U) && GUIActive == false; }
        public bool getUUp() { return UnityEngine.Input.GetKeyUp(KeyCode.U) && GUIActive == false; }

        public bool getI() { return UnityEngine.Input.GetKey(KeyCode.I) && GUIActive == false; }
        public bool getIDown() { return UnityEngine.Input.GetKeyDown(KeyCode.I) && GUIActive == false; }
        public bool getIUp() { return UnityEngine.Input.GetKeyUp(KeyCode.I) && GUIActive == false; }

        public bool getO() { return UnityEngine.Input.GetKey(KeyCode.O) && GUIActive == false; }
        public bool getODown() { return UnityEngine.Input.GetKeyDown(KeyCode.O) && GUIActive == false; }
        public bool getOUp() { return UnityEngine.Input.GetKeyUp(KeyCode.O) && GUIActive == false; }

        public bool getP() { return UnityEngine.Input.GetKey(KeyCode.P) && GUIActive == false; }
        public bool getPDown() { return UnityEngine.Input.GetKeyDown(KeyCode.P) && GUIActive == false; }
        public bool getPUp() { return UnityEngine.Input.GetKeyUp(KeyCode.P) && GUIActive == false; }

        public bool getLeftBracket() { return UnityEngine.Input.GetKey(KeyCode.LeftBracket) && GUIActive == false; }
        public bool getLeftBracketDown() { return UnityEngine.Input.GetKeyDown(KeyCode.LeftBracket) && GUIActive == false; }
        public bool getLeftBracketUp() { return UnityEngine.Input.GetKeyUp(KeyCode.LeftBracket) && GUIActive == false; }

        public bool getRightBracket() { return UnityEngine.Input.GetKey(KeyCode.RightBracket) && GUIActive == false; }
        public bool getRightBracketDown() { return UnityEngine.Input.GetKeyDown(KeyCode.RightBracket) && GUIActive == false; }
        public bool getRightBracketUp() { return UnityEngine.Input.GetKeyUp(KeyCode.RightBracket) && GUIActive == false; }

        public bool getBackslash() { return UnityEngine.Input.GetKey(KeyCode.Backslash) && GUIActive == false; }
        public bool getBackslashDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Backslash) && GUIActive == false; }
        public bool getBackslashUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Backslash) && GUIActive == false; }

        //

        public bool getCapsLock() { return UnityEngine.Input.GetKey(KeyCode.CapsLock) && GUIActive == false; }
        public bool getCapsLockDown() { return UnityEngine.Input.GetKeyDown(KeyCode.CapsLock) && GUIActive == false; }
        public bool getCapsLockUp() { return UnityEngine.Input.GetKeyUp(KeyCode.CapsLock) && GUIActive == false; }

        public bool getA() { return UnityEngine.Input.GetKey(KeyCode.A) && GUIActive == false; }
        public bool getADown() { return UnityEngine.Input.GetKeyDown(KeyCode.A) && GUIActive == false; }
        public bool getAUp() { return UnityEngine.Input.GetKeyUp(KeyCode.A) && GUIActive == false; }

        public bool getS() { return UnityEngine.Input.GetKey(KeyCode.S) && GUIActive == false; }
        public bool getSDown() { return UnityEngine.Input.GetKeyDown(KeyCode.S) && GUIActive == false; }
        public bool getSUp() { return UnityEngine.Input.GetKeyUp(KeyCode.S) && GUIActive == false; }

        public bool getD() { return UnityEngine.Input.GetKey(KeyCode.D) && GUIActive == false; }
        public bool getDDown() { return UnityEngine.Input.GetKeyDown(KeyCode.D) && GUIActive == false; }
        public bool getDUp() { return UnityEngine.Input.GetKeyUp(KeyCode.D) && GUIActive == false; }

        public bool getF() { return UnityEngine.Input.GetKey(KeyCode.F) && GUIActive == false; }
        public bool getFDown() { return UnityEngine.Input.GetKeyDown(KeyCode.F) && GUIActive == false; }
        public bool getFUp() { return UnityEngine.Input.GetKeyUp(KeyCode.F) && GUIActive == false; }

        public bool getG() { return UnityEngine.Input.GetKey(KeyCode.G) && GUIActive == false; }
        public bool getGDown() { return UnityEngine.Input.GetKeyDown(KeyCode.G) && GUIActive == false; }
        public bool getGUp() { return UnityEngine.Input.GetKeyUp(KeyCode.G) && GUIActive == false; }

        public bool getH() { return UnityEngine.Input.GetKey(KeyCode.H) && GUIActive == false; }
        public bool getHDown() { return UnityEngine.Input.GetKeyDown(KeyCode.H) && GUIActive == false; }
        public bool getHUp() { return UnityEngine.Input.GetKeyUp(KeyCode.H) && GUIActive == false; }

        public bool getJ() { return UnityEngine.Input.GetKey(KeyCode.J) && GUIActive == false; }
        public bool getJDown() { return UnityEngine.Input.GetKeyDown(KeyCode.J) && GUIActive == false; }
        public bool getJUp() { return UnityEngine.Input.GetKeyUp(KeyCode.J) && GUIActive == false; }

        public bool getK() { return UnityEngine.Input.GetKey(KeyCode.K) && GUIActive == false; }
        public bool getKDown() { return UnityEngine.Input.GetKeyDown(KeyCode.K) && GUIActive == false; }
        public bool getKUp() { return UnityEngine.Input.GetKeyUp(KeyCode.K) && GUIActive == false; }

        public bool getL() { return UnityEngine.Input.GetKey(KeyCode.L) && GUIActive == false; }
        public bool getLDown() { return UnityEngine.Input.GetKeyDown(KeyCode.L) && GUIActive == false; }
        public bool getLUp() { return UnityEngine.Input.GetKeyUp(KeyCode.L) && GUIActive == false; }

        public bool getSemicolon() { return UnityEngine.Input.GetKey(KeyCode.Semicolon) && GUIActive == false; }
        public bool getSemicolonDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Semicolon) && GUIActive == false; }
        public bool getSemicolonUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Semicolon) && GUIActive == false; }

        public bool getQuote() { return UnityEngine.Input.GetKey(KeyCode.Quote) && GUIActive == false; }
        public bool getQuoteDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Quote) && GUIActive == false; }
        public bool getQuoteUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Quote) && GUIActive == false; }

        public bool getReturn() { return UnityEngine.Input.GetKey(KeyCode.Return) && GUIActive == false; }
        public bool getReturnDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Return) && GUIActive == false; }
        public bool getReturnUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Return) && GUIActive == false; }

        //

        public bool getLeftShift() { return UnityEngine.Input.GetKey(KeyCode.LeftShift) && GUIActive == false; }
        public bool getLeftShiftDown() { return UnityEngine.Input.GetKeyDown(KeyCode.LeftShift) && GUIActive == false; }
        public bool getLeftShiftUp() { return UnityEngine.Input.GetKeyUp(KeyCode.LeftShift) && GUIActive == false; }

        public bool getZ() { return UnityEngine.Input.GetKey(KeyCode.Z) && GUIActive == false; }
        public bool getZDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Z) && GUIActive == false; }
        public bool getZUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Z) && GUIActive == false; }

        public bool getX() { return UnityEngine.Input.GetKey(KeyCode.X) && GUIActive == false; }
        public bool getXDown() { return UnityEngine.Input.GetKeyDown(KeyCode.X) && GUIActive == false; }
        public bool getXUp() { return UnityEngine.Input.GetKeyUp(KeyCode.X) && GUIActive == false; }

        public bool getC() { return UnityEngine.Input.GetKey(KeyCode.C) && GUIActive == false; }
        public bool getCDown() { return UnityEngine.Input.GetKeyDown(KeyCode.C) && GUIActive == false; }
        public bool getCUp() { return UnityEngine.Input.GetKeyUp(KeyCode.C) && GUIActive == false; }

        public bool getV() { return UnityEngine.Input.GetKey(KeyCode.V) && GUIActive == false; }
        public bool getVDown() { return UnityEngine.Input.GetKeyDown(KeyCode.V) && GUIActive == false; }
        public bool getVUp() { return UnityEngine.Input.GetKeyUp(KeyCode.V) && GUIActive == false; }

        public bool getB() { return UnityEngine.Input.GetKey(KeyCode.B) && GUIActive == false; }
        public bool getBDown() { return UnityEngine.Input.GetKeyDown(KeyCode.B) && GUIActive == false; }
        public bool getBUp() { return UnityEngine.Input.GetKeyUp(KeyCode.B) && GUIActive == false; }

        public bool getN() { return UnityEngine.Input.GetKey(KeyCode.N) && GUIActive == false; }
        public bool getNDown() { return UnityEngine.Input.GetKeyDown(KeyCode.N) && GUIActive == false; }
        public bool getNUp() { return UnityEngine.Input.GetKeyUp(KeyCode.N) && GUIActive == false; }

        public bool getM() { return UnityEngine.Input.GetKey(KeyCode.M) && GUIActive == false; }
        public bool getMDown() { return UnityEngine.Input.GetKeyDown(KeyCode.M) && GUIActive == false; }
        public bool getMUp() { return UnityEngine.Input.GetKeyUp(KeyCode.M) && GUIActive == false; }

        public bool getComma() { return UnityEngine.Input.GetKey(KeyCode.Comma) && GUIActive == false; }
        public bool getCommaDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Comma) && GUIActive == false; }
        public bool getCommaUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Comma) && GUIActive == false; }

        public bool getPeriod() { return UnityEngine.Input.GetKey(KeyCode.Period) && GUIActive == false; }
        public bool getPeriodDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Period) && GUIActive == false; }
        public bool getPeriodUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Period) && GUIActive == false; }

        public bool getSlash() { return UnityEngine.Input.GetKey(KeyCode.Slash) && GUIActive == false; }
        public bool getSlashDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Slash) && GUIActive == false; }
        public bool getSlashUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Slash) && GUIActive == false; }

        public bool getRightShift() { return UnityEngine.Input.GetKey(KeyCode.RightShift) && GUIActive == false; }
        public bool getRightShiftDown() { return UnityEngine.Input.GetKeyDown(KeyCode.RightShift) && GUIActive == false; }
        public bool getRightShiftUp() { return UnityEngine.Input.GetKeyUp(KeyCode.RightShift) && GUIActive == false; }

        //

        public bool getLeftCtrl() { return UnityEngine.Input.GetKey(KeyCode.LeftControl) && GUIActive == false; }
        public bool getLeftCtrlDown() { return UnityEngine.Input.GetKeyDown(KeyCode.LeftControl) && GUIActive == false; }
        public bool getLeftCtrlUp() { return UnityEngine.Input.GetKeyUp(KeyCode.LeftControl) && GUIActive == false; }

        public bool getLeftWindows() { return UnityEngine.Input.GetKey(KeyCode.LeftWindows) && GUIActive == false; }
        public bool getLeftWindowsDown() { return UnityEngine.Input.GetKeyDown(KeyCode.LeftWindows) && GUIActive == false; }
        public bool getLeftWindowsUp() { return UnityEngine.Input.GetKeyUp(KeyCode.LeftWindows) && GUIActive == false; }

        public bool getLeftAlt() { return UnityEngine.Input.GetKey(KeyCode.LeftAlt) && GUIActive == false; }
        public bool getLeftAltDown() { return UnityEngine.Input.GetKeyDown(KeyCode.LeftAlt) && GUIActive == false; }
        public bool getLeftAltUp() { return UnityEngine.Input.GetKeyUp(KeyCode.LeftAlt) && GUIActive == false; }

        public bool getSpace() { return UnityEngine.Input.GetKey(KeyCode.Space) && GUIActive == false; }
        public bool getSpaceDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Space) && GUIActive == false; }
        public bool getSpaceUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Space) && GUIActive == false; }

        public bool getRightAlt() { return UnityEngine.Input.GetKey(KeyCode.RightAlt) && GUIActive == false; }
        public bool getRightAltDown() { return UnityEngine.Input.GetKeyDown(KeyCode.RightAlt) && GUIActive == false; }
        public bool getRightAltUp() { return UnityEngine.Input.GetKeyUp(KeyCode.RightAlt) && GUIActive == false; }

        public bool getRightWindows() { return UnityEngine.Input.GetKey(KeyCode.RightWindows) && GUIActive == false; }
        public bool getRightWindowsDown() { return UnityEngine.Input.GetKeyDown(KeyCode.RightWindows) && GUIActive == false; }
        public bool getRightWindowsUp() { return UnityEngine.Input.GetKeyUp(KeyCode.RightWindows) && GUIActive == false; }

        public bool getContext() { return UnityEngine.Input.GetKey(KeyCode.Menu) && GUIActive == false; }
        public bool getContextDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Menu) && GUIActive == false; }
        public bool getContextUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Menu) && GUIActive == false; }

        public bool getRightCtrl() { return UnityEngine.Input.GetKey(KeyCode.RightControl) && GUIActive == false; }
        public bool getRightCtrlDown() { return UnityEngine.Input.GetKeyDown(KeyCode.RightControl) && GUIActive == false; }
        public bool getRightCtrlUp() { return UnityEngine.Input.GetKeyUp(KeyCode.RightControl) && GUIActive == false; }

        //

        public bool getLeft() { return UnityEngine.Input.GetKey(KeyCode.LeftArrow) && GUIActive == false; }
        public bool getLeftDown() { return UnityEngine.Input.GetKeyDown(KeyCode.LeftArrow) && GUIActive == false; }
        public bool getLeftUp() { return UnityEngine.Input.GetKeyUp(KeyCode.LeftArrow) && GUIActive == false; }

        public bool getRight() { return UnityEngine.Input.GetKey(KeyCode.RightArrow) && GUIActive == false; }
        public bool getRightDown() { return UnityEngine.Input.GetKeyDown(KeyCode.RightArrow) && GUIActive == false; }
        public bool getRightUp() { return UnityEngine.Input.GetKeyUp(KeyCode.RightArrow) && GUIActive == false; }

        public bool getUp() { return UnityEngine.Input.GetKey(KeyCode.UpArrow) && GUIActive == false; }
        public bool getUpDown() { return UnityEngine.Input.GetKeyDown(KeyCode.UpArrow) && GUIActive == false; }
        public bool getUpUp() { return UnityEngine.Input.GetKeyUp(KeyCode.UpArrow) && GUIActive == false; }

        public bool getDown() { return UnityEngine.Input.GetKey(KeyCode.DownArrow) && GUIActive == false; }
        public bool getDownDown() { return UnityEngine.Input.GetKeyDown(KeyCode.DownArrow) && GUIActive == false; }
        public bool getDownUp() { return UnityEngine.Input.GetKeyUp(KeyCode.DownArrow) && GUIActive == false; }

        //

        public bool getInsert() { return UnityEngine.Input.GetKey(KeyCode.Insert) && GUIActive == false; }
        public bool getInsertDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Insert) && GUIActive == false; }
        public bool getInsertUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Insert) && GUIActive == false; }

        public bool getHome() { return UnityEngine.Input.GetKey(KeyCode.Home) && GUIActive == false; }
        public bool getHomeDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Home) && GUIActive == false; }
        public bool getHomeUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Home) && GUIActive == false; }

        public bool getPageUp() { return UnityEngine.Input.GetKey(KeyCode.PageUp) && GUIActive == false; }
        public bool getPageUpDown() { return UnityEngine.Input.GetKeyDown(KeyCode.PageUp) && GUIActive == false; }
        public bool getPageUpUp() { return UnityEngine.Input.GetKeyUp(KeyCode.PageUp) && GUIActive == false; }

        public bool getDelete() { return UnityEngine.Input.GetKey(KeyCode.Delete) && GUIActive == false; }
        public bool getDeleteDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Delete) && GUIActive == false; }
        public bool getDeleteUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Delete) && GUIActive == false; }

        public bool getEnd() { return UnityEngine.Input.GetKey(KeyCode.End) && GUIActive == false; }
        public bool getEndDown() { return UnityEngine.Input.GetKeyDown(KeyCode.End) && GUIActive == false; }
        public bool getEndUp() { return UnityEngine.Input.GetKeyUp(KeyCode.End) && GUIActive == false; }

        public bool getPageDown() { return UnityEngine.Input.GetKey(KeyCode.PageDown) && GUIActive == false; }
        public bool getPageDownDown() { return UnityEngine.Input.GetKeyDown(KeyCode.PageDown) && GUIActive == false; }
        public bool getPageDownUp() { return UnityEngine.Input.GetKeyUp(KeyCode.PageDown) && GUIActive == false; }

        //

        public bool getNumlock() { return UnityEngine.Input.GetKey(KeyCode.Numlock) && GUIActive == false; }
        public bool getNumlockDown() { return UnityEngine.Input.GetKeyDown(KeyCode.Numlock) && GUIActive == false; }
        public bool getNumlockUp() { return UnityEngine.Input.GetKeyUp(KeyCode.Numlock) && GUIActive == false; }

        public bool getKeypadDivide() { return UnityEngine.Input.GetKey(KeyCode.KeypadDivide) && GUIActive == false; }
        public bool getKeypadDivideDown() { return UnityEngine.Input.GetKeyDown(KeyCode.KeypadDivide) && GUIActive == false; }
        public bool getKeypadDivideUp() { return UnityEngine.Input.GetKeyUp(KeyCode.KeypadDivide) && GUIActive == false; }

        public bool getKeypadMultiply() { return UnityEngine.Input.GetKey(KeyCode.KeypadMultiply) && GUIActive == false; }
        public bool getKeypadMultiplyDown() { return UnityEngine.Input.GetKeyDown(KeyCode.KeypadMultiply) && GUIActive == false; }
        public bool getKeypadMultiplyUp() { return UnityEngine.Input.GetKeyUp(KeyCode.KeypadMultiply) && GUIActive == false; }

        public bool getKeypadMinus() { return UnityEngine.Input.GetKey(KeyCode.KeypadMinus) && GUIActive == false; }
        public bool getKeypadMinusDown() { return UnityEngine.Input.GetKeyDown(KeyCode.KeypadMinus) && GUIActive == false; }
        public bool getKeypadMinusUp() { return UnityEngine.Input.GetKeyUp(KeyCode.KeypadMinus) && GUIActive == false; }

        public bool getKeypadPlus() { return UnityEngine.Input.GetKey(KeyCode.KeypadPlus) && GUIActive == false; }
        public bool getKeypadPlusDown() { return UnityEngine.Input.GetKeyDown(KeyCode.KeypadPlus) && GUIActive == false; }
        public bool getKeypadPlusUp() { return UnityEngine.Input.GetKeyUp(KeyCode.KeypadPlus) && GUIActive == false; }

        public bool getKeypadEnter() { return UnityEngine.Input.GetKey(KeyCode.KeypadEnter) && GUIActive == false; }
        public bool getKeypadEnterDown() { return UnityEngine.Input.GetKeyDown(KeyCode.KeypadEnter) && GUIActive == false; }
        public bool getKeypadEnterUp() { return UnityEngine.Input.GetKeyUp(KeyCode.KeypadEnter) && GUIActive == false; }

        public bool getKeypadPeriod() { return UnityEngine.Input.GetKey(KeyCode.KeypadPeriod) && GUIActive == false; }
        public bool getKeypadPeriodDown() { return UnityEngine.Input.GetKeyDown(KeyCode.KeypadPeriod) && GUIActive == false; }
        public bool getKeypadPeriodUp() { return UnityEngine.Input.GetKeyUp(KeyCode.KeypadPeriod) && GUIActive == false; }

        public bool getKeypad0() { return UnityEngine.Input.GetKey(KeyCode.Keypad0) && GUIActive == false; }
        public bool getKeypad0Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad0) && GUIActive == false; }
        public bool getKeypad0Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad0) && GUIActive == false; }

        public bool getKeypad1() { return UnityEngine.Input.GetKey(KeyCode.Keypad1) && GUIActive == false; }
        public bool getKeypad1Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad1) && GUIActive == false; }
        public bool getKeypad1Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad1) && GUIActive == false; }

        public bool getKeypad2() { return UnityEngine.Input.GetKey(KeyCode.Keypad2) && GUIActive == false; }
        public bool getKeypad2Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad2) && GUIActive == false; }
        public bool getKeypad2Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad2) && GUIActive == false; }

        public bool getKeypad3() { return UnityEngine.Input.GetKey(KeyCode.Keypad3) && GUIActive == false; }
        public bool getKeypad3Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad3) && GUIActive == false; }
        public bool getKeypad3Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad3) && GUIActive == false; }

        public bool getKeypad4() { return UnityEngine.Input.GetKey(KeyCode.Keypad4) && GUIActive == false; }
        public bool getKeypad4Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad4) && GUIActive == false; }
        public bool getKeypad4Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad4) && GUIActive == false; }

        public bool getKeypad5() { return UnityEngine.Input.GetKey(KeyCode.Keypad5) && GUIActive == false; }
        public bool getKeypad5Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad5) && GUIActive == false; }
        public bool getKeypad5Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad5) && GUIActive == false; }

        public bool getKeypad6() { return UnityEngine.Input.GetKey(KeyCode.Keypad6) && GUIActive == false; }
        public bool getKeypad6Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad6) && GUIActive == false; }
        public bool getKeypad6Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad6) && GUIActive == false; }

        public bool getKeypad7() { return UnityEngine.Input.GetKey(KeyCode.Keypad7) && GUIActive == false; }
        public bool getKeypad7Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad7) && GUIActive == false; }
        public bool getKeypad7Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad7) && GUIActive == false; }

        public bool getKeypad8() { return UnityEngine.Input.GetKey(KeyCode.Keypad8) && GUIActive == false; }
        public bool getKeypad8Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad8) && GUIActive == false; }
        public bool getKeypad8Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad8) && GUIActive == false; }

        public bool getKeypad9() { return UnityEngine.Input.GetKey(KeyCode.Keypad9) && GUIActive == false; }
        public bool getKeypad9Down() { return UnityEngine.Input.GetKeyDown(KeyCode.Keypad9) && GUIActive == false; }
        public bool getKeypad9Up() { return UnityEngine.Input.GetKeyUp(KeyCode.Keypad9) && GUIActive == false; }
    }
    /// <summary>
    /// Contains all the data for the keyboard.
    /// </summary>
    public Keyboard keyboard = new Keyboard();

    /// <summary>
    /// Contains all the data for a mouse.
    /// </summary>
    [System.Serializable]
    public class Mouse
    {
        /// <summary>
        /// If the mouse is active or not.
        /// </summary>
        public bool active;

        /// <summary>
        /// The mouses' position on the screen.
        /// </summary>
        public Vector2 position;

        [HideInInspector]
        public float scroll;
        /// <summary>
        /// Get if mouse is scrolling up.
        /// </summary>
        public bool getScrollUp() { return scroll > 0f; }
        /// <summary>
        /// Get if mouse is scrolling down.
        /// </summary>
        public bool getScrollDown() { return scroll < 0f; }

        /// <summary>
        /// Detect if left mouse button.
        /// </summary>
        public bool getL() { return UnityEngine.Input.GetMouseButton(0); }
        /// <summary>
        /// Detect if left mouse button is down.
        /// </summary>
        public bool getLDown() { return UnityEngine.Input.GetMouseButtonDown(0); }
        /// <summary>
        /// Detect if left mouse button is up.
        /// </summary>
        public bool getLUp() { return UnityEngine.Input.GetMouseButtonUp(0); }

        /// <summary>
        /// Detect if center mouse button.
        /// </summary>
        public bool getC() { return UnityEngine.Input.GetMouseButton(2); }
        /// <summary>
        /// Detect if center mouse button is down.
        /// </summary>
        public bool getCDown() { return UnityEngine.Input.GetMouseButtonDown(2); }
        /// <summary>
        /// Detect if center mouse button is up.
        /// </summary>
        public bool getCUp() { return UnityEngine.Input.GetMouseButtonUp(2); }

        /// <summary>
        /// Detect if right mouse button.
        /// </summary>
        public bool getR() { return UnityEngine.Input.GetMouseButton(1); }
        /// <summary>
        /// Detect if right mouse button is down.
        /// </summary>
        public bool getRDown() { return UnityEngine.Input.GetMouseButtonDown(1); }
        /// <summary>
        /// Detect if right mouse button is up.
        /// </summary>
        public bool getRUp() { return UnityEngine.Input.GetMouseButtonUp(1); }
    }
    /// <summary>
    /// Contains all the data on the mouse.
    /// </summary>
    public Mouse mouse = new Mouse();

    /// <summary>
    /// Contains all the data for a joystick.
    /// </summary>
    [System.Serializable]
    public class JoyStick
    {
        public bool active;

        public Vector2 Axis0;
        public Vector2 Axis0Prev;

        public bool getAxis0Up() { return Axis0.y > 0.95f; }
        public bool getAxis0UpDown() { return Axis0.y > 0.95f && Axis0Prev.y < 0.95f; }
        public bool getAxis0UpUp() { return Axis0.y < 0.95f && Axis0Prev.y > 0.95f; }

        public bool getAxis0Down() { return Axis0.y < -0.95f; }
        public bool getAxis0DownDown() { return Axis0.y < -0.95f && Axis0Prev.y > -0.95f; }
        public bool getAxis0DownUp() { return Axis0.y > -0.95f && Axis0Prev.y < -0.95f; }

        public bool getAxis0Left() { return Axis0.x < -0.95f; }
        public bool getAxis0LeftDown() { return Axis0.x < -0.95f && Axis0Prev.x > -0.95f; }
        public bool getAxis0LeftUp() { return Axis0.x > -0.95f && Axis0Prev.x < -0.95f; }

        public bool getAxis0Right() { return Axis0.x > 0.95f; }
        public bool getAxis0RightDown() { return Axis0.x > 0.95f && Axis0Prev.x < 0.95f; }
        public bool getAxis0RightUp() { return Axis0.x < 0.95f && Axis0Prev.x > 0.95f; }


        public Vector2 Axis1;
        public Vector2 Axis1Prev;

        public bool getAxis1Up() { return Axis1.y > 0.95f; }
        public bool getAxis1UpDown() { return Axis1.y > 0.95f && Axis1Prev.y < 0.95f; }
        public bool getAxis1UpUp() { return Axis1.y < 0.95f && Axis1Prev.y > 0.95f; }

        public bool getAxis1Down() { return Axis1.y < -0.95f; }
        public bool getAxis1DownDown() { return Axis1.y < -0.95f && Axis1Prev.y > -0.95f; }
        public bool getAxis1DownUp() { return Axis1.y > -0.95f && Axis1Prev.y < -0.95f; }

        public bool getAxis1Left() { return Axis1.x < -0.95f; }
        public bool getAxis1LeftDown() { return Axis1.x < -0.95f && Axis1Prev.x > -0.95f; }
        public bool getAxis1LeftUp() { return Axis1.x > -0.95f && Axis1Prev.x < -0.95f; }

        public bool getAxis1Right() { return Axis1.x > 0.95f; }
        public bool getAxis1RightDown() { return Axis1.x > 0.95f && Axis1Prev.x < 0.95f; }
        public bool getAxis1RightUp() { return Axis1.x < 0.95f && Axis1Prev.x > 0.95f; }

        public Vector2 Axis2;
        public Vector2 Axis2Prev;

        public bool getAxis2Up() { return Axis2.y > 0.95f; }
        public bool getAxis2UpDown() { return Axis2.y > 0.95f && Axis2Prev.y < 0.95f; }
        public bool getAxis2UpUp() { return Axis2.y < 0.95f && Axis2Prev.y > 0.95f; }

        public bool getAxis2Down() { return Axis2.y < -0.95f; }
        public bool getAxis2DownDown() { return Axis2.y < -0.95f && Axis2Prev.y > -0.95f; }
        public bool getAxis2DownUp() { return Axis2.y > -0.95f && Axis2Prev.y < -0.95f; }

        public bool getAxis2Left() { return Axis2.x < -0.95f; }
        public bool getAxis2LeftDown() { return Axis2.x < -0.95f && Axis2Prev.x > -0.95f; }
        public bool getAxis2LeftUp() { return Axis2.x > -0.95f && Axis2Prev.x < -0.95f; }

        public bool getAxis2Right() { return Axis2.x > 0.95f; }
        public bool getAxis2RightDown() { return Axis2.x > 0.95f && Axis2Prev.x < 0.95f; }
        public bool getAxis2RightUp() { return Axis2.x < 0.95f && Axis2Prev.x > 0.95f; }

        public bool lb;
        [HideInInspector]
        public bool lbPrev;

        public bool getLB() { return lb; }
        public bool getLBDown() { return lbPrev == false && lb == true; }
        public bool getLBUp() { return lbPrev == true && lb == false; }

        public bool rb;
        [HideInInspector]
        public bool rbPrev;

        public bool getRB() { return rb; }
        public bool getRBDown() { return rbPrev == false && rb == true; }
        public bool getRBUp() { return rbPrev == true && rb == false; }

        public bool back;
        [HideInInspector]
        public bool backPrev;

        public bool getBack() { return back; }
        public bool getBackDown() { return backPrev == false && back == true; }
        public bool getBackUp() { return backPrev == true && back == false; }

        // Start
        public bool start;
        [HideInInspector]
        public bool startPrev;

        public bool getStart() { return start; }
        public bool getStartDown() { return startPrev == false && start == true; }
        public bool getStartUp() { return startPrev == true && start == false; }

        // A
        public bool a;
        [HideInInspector]
        public bool aPrev;

        public bool getA() { return a; }
        public bool getADown() { return aPrev == false && a == true; }
        public bool getAUp() { return aPrev == true && a == false; }

        // B
        public bool b;
        [HideInInspector]
        public bool bPrev;

        public bool getB() { return b; }
        public bool getBDown() { return bPrev == false && b == true; }
        public bool getBUp() { return bPrev == true && b == false; }

        public bool x;
        [HideInInspector]
        public bool xPrev;

        public bool getX() { return x; }
        public bool getXDown() { return xPrev == false && x == true; }
        public bool getXUp() { return xPrev == true && x == false; }

        public bool y;
        [HideInInspector]
        public bool yPrev;

        public bool getY() { return y; }
        public bool getYDown() { return yPrev == false && y == true; }
        public bool getYUp() { return yPrev == true && y == false; }

        public void ResetJoyStick()
        {
            Axis0 = Vector2.zero;
            Axis1 = Vector2.zero;
            Axis2 = Vector2.zero;

            back = false;
            backPrev = false;
            start = false;
            startPrev = false;
            a = false;
            aPrev = false;
            b = false;
            bPrev = false;
            x = false;
            xPrev = false;
            y = false;
            yPrev = false;
        }

        public JoyStick() { }
    }
    /// <summary>
    /// Contains all the data for the 4 joysticks.
    /// </summary>
    public JoyStick[] joysticks = new JoyStick[4];
    /// <summary>
    /// Which joysticks are currently active.
    /// </summary>
    public bool[] activeJoysticks = new bool[4];
    /// <summary>
    /// The number of currently active joysticks.
    /// </summary>
    public int activeJoysticksCount = 0;

    /// <summary>
    /// Contains all the data for the master joystick.
    /// </summary>
    [System.Serializable]
    public class MasterJoyStick
    {
        public bool active;

        public Vector2 Axis0Prev;
        public Vector2 Axis0;

        public bool getAxis0Up() { return Axis0.y > 0.90f; }
        public bool getAxis0UpDown() { return Axis0.y > 0.90f && Axis0Prev.y < 0.90f; }
        public bool getAxis0UpUp() { return Axis0.y < 0.90f && Axis0Prev.y > 0.90f; }

        public bool getAxis0Down() { return Axis0.y < -0.90f; }
        public bool getAxis0DownDown() { return Axis0.y < -0.90f && Axis0Prev.y > -0.90f; }
        public bool getAxis0DownUp() { return Axis0.y > -0.90f && Axis0Prev.y < -0.90f; }

        public bool getAxis0Left() { return Axis0.x < -0.90f; }
        public bool getAxis0LeftDown() { return Axis0.x < -0.90f && Axis0Prev.x > -0.90f; }
        public bool getAxis0LeftUp() { return Axis0.x > -0.90f && Axis0Prev.x < -0.90f; }

        public bool getAxis0Right() { return Axis0.x > 0.90f; }
        public bool getAxis0RightDown() { return Axis0.x > 0.90f && Axis0Prev.x < 0.90f; }
        public bool getAxis0RightUp() { return Axis0.x < 0.90f && Axis0Prev.x > 0.90f; }

        public Vector2 Axis1Prev;
        public Vector2 Axis1;

        public bool getAxis1Up() { return Axis1.y > 0.90f; }
        public bool getAxis1UpDown() { return Axis1.y > 0.90f && Axis1Prev.y < 0.90f; }
        public bool getAxis1UpUp() { return Axis1.y < 0.90f && Axis1Prev.y > 0.90f; }

        public bool getAxis1Down() { return Axis1.y < -0.90f; }
        public bool getAxis1DownDown() { return Axis1.y < -0.90f && Axis1Prev.y > -0.90f; }
        public bool getAxis1DownUp() { return Axis1.y > -0.90f && Axis1Prev.y < -0.90f; }

        public bool getAxis1Left() { return Axis1.x < -0.90f; }
        public bool getAxis1LeftDown() { return Axis1.x < -0.90f && Axis1Prev.x > -0.90f; }
        public bool getAxis1LeftUp() { return Axis1.x > -0.90f && Axis1Prev.x < -0.90f; }

        public bool getAxis1Right() { return Axis1.x > 0.90f; }
        public bool getAxis1RightDown() { return Axis1.x > 0.90f && Axis1Prev.x < 0.90f; }
        public bool getAxis1RightUp() { return Axis1.x < 0.90f && Axis1Prev.x > 0.90f; }

        public Vector2 Axis2Prev;
        public Vector2 Axis2;

        public bool getAxis2Up() { return Axis2.y > 0.90f; }
        public bool getAxis2UpDown() { return Axis2.y > 0.90f && Axis2Prev.y < 0.90f; }
        public bool getAxis2UpUp() { return Axis2.y < 0.90f && Axis2Prev.y > 0.90f; }

        public bool getAxis2Down() { return Axis2.y < -0.90f; }
        public bool getAxis2DownDown() { return Axis2.y < -0.90f && Axis2Prev.y > -0.90f; }
        public bool getAxis2DownUp() { return Axis2.y > -0.90f && Axis2Prev.y < -0.90f; }

        public bool getAxis2Left() { return Axis2.x < -0.90f; }
        public bool getAxis2LeftDown() { return Axis2.x < -0.90f && Axis2Prev.x > -0.90f; }
        public bool getAxis2LeftUp() { return Axis2.x > -0.90f && Axis2Prev.x < -0.90f; }

        public bool getAxis2Right() { return Axis2.x > 0.90f; }
        public bool getAxis2RightDown() { return Axis2.x > 0.90f && Axis2Prev.x < 0.90f; }
        public bool getAxis2RightUp() { return Axis2.x < 0.90f && Axis2Prev.x > 0.90f; }

        // LB
        public int lb;
        public int lbDown;
        public int lbUp;

        public bool getLB() { return (lb > 0); }
        public bool getLBDown() { return (lbDown > 0); }
        public bool getLBUp() { return (lbUp > 0); }

        // RB
        public int rb;
        public int rbDown;
        public int rbUp;

        public bool getRB() { return (rb > 0); }
        public bool getRBDown() { return (rbDown > 0); }
        public bool getRBUp() { return (rbUp > 0); }

        // Back
        public int back;
        public int backDown;
        public int backUp;

        public bool getBack() { return (back > 0); }
        public bool getBackDown() { return (backDown > 0); }
        public bool getBackUp() { return (backUp > 0); }

        // Start
        public int start;
        public int startDown;
        public int startUp;

        public bool getStart() { return (start > 0); }
        public bool getStartDown() { return (startDown > 0); }
        public bool getStartUp() { return (startUp > 0); }

        // A
        public int a;
        public int aDown;
        public int aUp;

        public bool getA() { return (a > 0); }
        public bool getADown() { return (aDown > 0); }
        public bool getAUp() { return (aUp > 0); }

        // B
        public int b;
        public int bDown;
        public int bUp;

        public bool getB() { return (b > 0); }
        public bool getBDown() { return (bDown > 0); }
        public bool getBUp() { return (bUp > 0); }

        // X
        public int x;
        public int xDown;
        public int xUp;

        public bool getX() { return (x > 0); }
        public bool getXDown() { return (xDown > 0); }
        public bool getXUp() { return (xUp > 0); }

        // Y
        public int y;
        public int yDown;
        public int yUp;

        public bool getY() { return (y > 0); }
        public bool getYDown() { return (yDown > 0); }
        public bool getYUp() { return (yUp > 0); }

        /// <summary>
        /// Reset Master Joystick
        /// </summary>
        public void ResetJoyStick()
        {
            Axis0 = Vector2.zero;
            Axis0Prev = Vector2.zero;
            Axis1 = Vector2.zero;
            Axis1Prev = Vector2.zero;
            Axis2 = Vector2.zero;
            Axis2Prev = Vector2.zero;

            // LB
            lb = 0;
            lbDown = 0;
            lbUp = 0;

            // RB
            rb = 0;
            rbDown = 0;
            rbUp = 0;

            // Back
            back = 0;
            backDown = 0;
            backUp = 0;

            // Start
            start = 0;
            startDown = 0;
            startUp = 0;

            // A
            a = 0;
            aDown = 0;
            aUp = 0;

            // B
            b = 0;
            bDown = 0;
            bUp = 0;

            // X
            x = 0;
            xDown = 0;
            xUp = 0;

            // Y
            y = 0;
            yDown = 0;
            yUp = 0;

        }

        /// <summary>
        /// Create Master Joystick.
        /// </summary>
        public MasterJoyStick() { }
    }

    public MasterJoyStick joystick = new MasterJoyStick();

    /// <summary>
    /// Updates all the inputs.
    /// </summary>
    public void UpdateAll()
    {
        if (!activeOnGUIFocus)
        {
            if (EventSystem.current.currentSelectedGameObject != null &&
               (EventSystem.current.currentSelectedGameObject.GetComponent<UnityEngine.UI.Text>() != null ||
                EventSystem.current.currentSelectedGameObject.GetComponent<UnityEngine.UI.InputField>() != null))
            {
                GUIActive = true;
            }
            else
            {
                GUIActive = false;
            }
        }

        UpdateJoysticks();
        UpdateKeyboard();
        UpdateMouse();
    }

    /// <summary>
    /// Updates the keyboard.
    /// </summary>
    public void UpdateKeyboard()
    {

    }

    /// <summary>
    /// Updates the mouse.
    /// </summary>
    public void UpdateMouse()
    {
        mouse.position = new Vector2(UnityEngine.Input.mousePosition.x, UnityEngine.Input.mousePosition.y);

        //Scroll Wheel
        mouse.scroll = UnityEngine.Input.GetAxisRaw("MouseScroll");
    }

    /// <summary>
    /// Gets a joystick key.
    /// </summary>
    /// <param name="joystick">Joystick to get.</param>
    /// <param name="button">Key to get.</param>
    /// <returns></returns>
    public bool GetJoystickKey(int joystick, int button)
    {
        return (UnityEngine.Input.GetKey(string.Format("joystick {0} button {1}", joystick + 1, button))) ? true : false;
    }

    /// <summary>
    /// Updates the joysticks.
    /// </summary>
    public void UpdateJoysticks()
    {
        activeJoysticksCount = 0;
        for (int i = 0; i <= 3; i++)
        {
            if (UnityEngine.Input.GetJoystickNames().Length > i)
            {
                if (UnityEngine.Input.GetJoystickNames()[i] != "")
                {
                    activeJoysticksCount++;
                    joysticks[i].active = true;
                    activeJoysticks[i] = true;
                }
                else
                {
                    joysticks[i].ResetJoyStick();
                    joysticks[i].active = false;
                    activeJoysticks[i] = false;
                }
            }
        }

        joystick.ResetJoyStick();

        for (int i = 0; i <= 3; i++)
        {
            if (activeJoysticks[i] == true)
            {
                //LB
                joysticks[i].lbPrev = joysticks[i].lb;
                joysticks[i].lb = (GetJoystickKey(i, 4));
                joystick.lb += (joysticks[i].getLB()) ? 1 : 0;
                joystick.lbDown += (joysticks[i].getLBDown()) ? 1 : 0;
                joystick.lbUp += (joysticks[i].getLBUp()) ? 1 : 0;

                //RB
                joysticks[i].rbPrev = joysticks[i].rb;
                joysticks[i].rb = (GetJoystickKey(i, 5));
                joystick.rb += (joysticks[i].getRB()) ? 1 : 0;
                joystick.rbDown += (joysticks[i].getRBDown()) ? 1 : 0;
                joystick.rbUp += (joysticks[i].getRBUp()) ? 1 : 0;

                //A
                joysticks[i].aPrev = joysticks[i].a;
                joysticks[i].a = (GetJoystickKey(i, 0));
                joystick.a += (joysticks[i].getA()) ? 1 : 0;
                joystick.aDown += (joysticks[i].getADown()) ? 1 : 0;
                joystick.aUp += (joysticks[i].getAUp()) ? 1 : 0;

                //B
                joysticks[i].bPrev = joysticks[i].b;
                joysticks[i].b = (GetJoystickKey(i, 1));
                joystick.b += (joysticks[i].getB()) ? 1 : 0;
                joystick.bDown += (joysticks[i].getBDown()) ? 1 : 0;
                joystick.bUp += (joysticks[i].getBUp()) ? 1 : 0;

                //X
                joysticks[i].xPrev = joysticks[i].x;
                joysticks[i].x = (GetJoystickKey(i, 2));
                joystick.x += (joysticks[i].getX()) ? 1 : 0;
                joystick.xDown += (joysticks[i].getXDown()) ? 1 : 0;
                joystick.xUp += (joysticks[i].getXUp()) ? 1 : 0;

                //Y
                joysticks[i].yPrev = joysticks[i].y;
                joysticks[i].y = (GetJoystickKey(i, 3));
                joystick.y += (joysticks[i].getY()) ? 1 : 0;
                joystick.yDown += (joysticks[i].getYDown()) ? 1 : 0;
                joystick.yUp += (joysticks[i].getYUp()) ? 1 : 0;

                //Back
                joysticks[i].backPrev = joysticks[i].back;
                joysticks[i].back = (GetJoystickKey(i, 6));
                joystick.back += (joysticks[i].getBack()) ? 1 : 0;
                joystick.backDown += (joysticks[i].getBackDown()) ? 1 : 0;
                joystick.backUp += (joysticks[i].getBackUp()) ? 1 : 0;

                //Start
                joysticks[i].startPrev = joysticks[i].start;
                joysticks[i].start = (GetJoystickKey(i, 7));
                joystick.start += (joysticks[i].getStart()) ? 1 : 0;
                joystick.startDown += (joysticks[i].getStartDown()) ? 1 : 0;
                joystick.startUp += (joysticks[i].getStartUp()) ? 1 : 0;

                //Axis0
                joysticks[i].Axis0Prev = joysticks[i].Axis0;
                joystick.Axis0Prev += joysticks[i].Axis0;
                joysticks[i].Axis0 = new Vector2(UnityEngine.Input.GetAxis("Joy" + i + "X"), UnityEngine.Input.GetAxis("Joy" + i + "Y") * -1);
                joystick.Axis0 += joysticks[i].Axis0;
                joystick.Axis0 = new Vector2(Mathf.Clamp(joystick.Axis0.x, -1, 1), Mathf.Clamp(joystick.Axis0.y, -1, 1));
                joystick.Axis0Prev = new Vector2(Mathf.Clamp(joystick.Axis0Prev.x, -1, 1), Mathf.Clamp(joystick.Axis0Prev.y, -1, 1));

                //Axis1
                joysticks[i].Axis1Prev = joysticks[i].Axis1;
                joystick.Axis1Prev += joysticks[i].Axis1;
                joysticks[i].Axis1 = new Vector2(UnityEngine.Input.GetAxis("Joy" + i + "X2"), UnityEngine.Input.GetAxis("Joy" + i + "Y2") * -1);
                joystick.Axis1 += joysticks[i].Axis1;
                joystick.Axis1 = new Vector2(Mathf.Clamp(joystick.Axis1.x, -1, 1), Mathf.Clamp(joystick.Axis1.y, -1, 1));
                joystick.Axis1Prev = new Vector2(Mathf.Clamp(joystick.Axis1Prev.x, -1, 1), Mathf.Clamp(joystick.Axis1Prev.y, -1, 1));

                //Axis2
                joysticks[i].Axis2Prev = joysticks[i].Axis2;
                joystick.Axis2Prev += joysticks[i].Axis2;
                joysticks[i].Axis2 = new Vector2(UnityEngine.Input.GetAxis("Joy" + i + "X3"), UnityEngine.Input.GetAxis("Joy" + i + "Y3"));
                joystick.Axis2 += joysticks[i].Axis2;
                joystick.Axis2 = new Vector2(Mathf.Clamp(joystick.Axis2.x, -1, 1), Mathf.Clamp(joystick.Axis2.y, -1, 1));
                joystick.Axis2Prev = new Vector2(Mathf.Clamp(joystick.Axis2Prev.x, -1, 1), Mathf.Clamp(joystick.Axis2Prev.y, -1, 1));
            }
        }
    }
}
