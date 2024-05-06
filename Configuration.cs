using System.Text.RegularExpressions;

namespace VsCodeThemeGenerator;

public static class Configuration
{
    public static readonly Regex HexColorRegex = new("#[0-9A-Fa-f]{6}");

    public static double[] Luminosities = [0.95, 0.90, 0.80, 0.70, 0.60, 0.50, 0.40, 0.30, 0.20, 0.10];

    public static Dictionary<string, string> Colors = new()
    {
        { "primary", "#8625D2" },
        { "secondary", "#FF508F" },
        { "tertiary", "#8625D2" },
        { "white", "#FFFFFF" },
        { "black", "#1A191F" },
        { "gray", "#5F5E61" },
        { "success", "#89DD13" },
        { "warning", "#FFCD25" },
        { "danger", "#FF413A" },
        { "category-frontend", "#DD0031" },
        { "category-backend", "#11D15E" },
        { "category-mobile", "#FF8C00" },
        { "category-data", "#FCDB04" },
        { "category-cloud", "#008DF1" },
        { "category-devops", "#0060F1" },
        { "category-fullstack", "#8625D2" }
    };

    public static Dictionary<string, string> BaseTheme = new()
    {
        { "activityBar.activeBorder", "#fd8c73" },
        { "activityBar.background", "#ffffff" },
        { "activityBar.border", "#848487" },
        { "activityBar.foreground", "#131219" },
        { "activityBar.inactiveForeground", "#5F5E61" },
        { "activityBarBadge.background", "#8625D2" },
        { "activityBarBadge.foreground", "#ffffff" },
        { "badge.background", "#8625D2" },
        { "badge.foreground", "#f7dcdc" },
        { "breadcrumb.activeSelectionForeground", "#5F5E61" },
        { "breadcrumb.focusForeground", "#131219" },
        { "breadcrumb.foreground", "#5F5E61" },
        { "breadcrumbPicker.background", "#ffffff" },
        { "button.background", "#11D15E" },
        { "button.foreground", "#ffffff" },
        { "button.hoverBackground", "#1a7f37" },
        { "button.secondaryBackground", "#ebecf0" },
        { "button.secondaryForeground", "#24292f" },
        { "button.secondaryHoverBackground", "#f3f4f6" },
        { "checkbox.background", "#f6f8fa" },
        { "checkbox.border", "#848487" },
        { "debugConsole.errorForeground", "#cf222e" },
        { "debugConsole.infoForeground", "#57606a" },
        { "debugConsole.sourceForeground", "#9a6700" },
        { "debugConsole.warningForeground", "#7d4e00" },
        { "debugConsoleInputIcon.foreground", "#6639ba" },
        { "debugIcon.breakpointForeground", "#cf222e" },
        { "debugTokenExpression.boolean", "#116329" },
        { "debugTokenExpression.error", "#a40e26" },
        { "debugTokenExpression.name", "#0550ae" },
        { "debugTokenExpression.number", "#116329" },
        { "debugTokenExpression.string", "#0a3069" },
        { "debugTokenExpression.value", "#0a3069" },
        { "debugToolBar.background", "#ffffff" },
        { "descriptionForeground", "#5F5E61" },
        { "diffEditor.insertedLineBackground", "#aceebb4d" },
        { "diffEditor.insertedTextBackground", "#6fdd8b80" },
        { "diffEditor.removedLineBackground", "#ffcecb4d" },
        { "diffEditor.removedTextBackground", "#ff818266" },
        { "dropdown.background", "#ffffff" },
        { "dropdown.border", "#848487" },
        { "dropdown.foreground", "#131219" },
        { "dropdown.listBackground", "#ffffff" },
        { "editor.background", "#ffffff" },
        { "editor.findMatchBackground", "#bf8700" },
        { "editor.findMatchHighlightBackground", "#fae17d80" },
        { "editor.focusedStackFrameHighlightBackground", "#4ac26b66" },
        { "editor.foldBackground", "#6e77811a" },
        { "editor.foreground", "#131219" },
        { "editor.lineHighlightBackground", "#eaeef280" },
        { "editor.linkedEditingBackground", "#8625D212" },
        { "editor.selectionHighlightBackground", "#4ac26b40" },
        { "editor.stackFrameHighlightBackground", "#d4a72c66" },
        { "editor.wordHighlightBackground", "#eaeef280" },
        { "editor.wordHighlightBorder", "#afb8c199" },
        { "editor.wordHighlightStrongBackground", "#afb8c14d" },
        { "editor.wordHighlightStrongBorder", "#afb8c199" },
        { "editorBracketHighlight.foreground1", "#8625D2" },
        { "editorBracketHighlight.foreground2", "#1a7f37" },
        { "editorBracketHighlight.foreground3", "#9a6700" },
        { "editorBracketHighlight.foreground4", "#cf222e" },
        { "editorBracketHighlight.foreground5", "#bf3989" },
        { "editorBracketHighlight.foreground6", "#8250df" },
        { "editorBracketHighlight.unexpectedBracket.foreground", "#5F5E61" },
        { "editorBracketMatch.background", "#4ac26b40" },
        { "editorBracketMatch.border", "#4ac26b99" },
        { "editorCursor.foreground", "#8625D2" },
        { "editorGroup.border", "#848487" },
        { "editorGroupHeader.tabsBackground", "#f6f8fa" },
        { "editorGroupHeader.tabsBorder", "#848487" },
        { "editorGutter.addedBackground", "#4ac26b66" },
        { "editorGutter.deletedBackground", "#ff818266" },
        { "editorGutter.modifiedBackground", "#d4a72c66" },
        { "editorIndentGuide.activeBackground", "#1312193d" },
        { "editorIndentGuide.background", "#1312191f" },
        { "editorInlayHint.background", "#afb8c133" },
        { "editorInlayHint.foreground", "#5F5E61" },
        { "editorInlayHint.typeBackground", "#afb8c133" },
        { "editorInlayHint.typeForeground", "#5F5E61" },
        { "editorLineNumber.activeForeground", "#131219" },
        { "editorLineNumber.foreground", "#8c959f" },
        { "editorOverviewRuler.border", "#ffffff" },
        { "editorWhitespace.foreground", "#afb8c1" },
        { "editorWidget.background", "#ffffff" },
        { "errorForeground", "#cf222e" },
        { "focusBorder", "#8625D2" },
        { "foreground", "#131219" },
        { "gitDecoration.addedResourceForeground", "#1a7f37" },
        { "gitDecoration.conflictingResourceForeground", "#bc4c00" },
        { "gitDecoration.deletedResourceForeground", "#cf222e" },
        { "gitDecoration.ignoredResourceForeground", "#6e7781" },
        { "gitDecoration.modifiedResourceForeground", "#9a6700" },
        { "gitDecoration.submoduleResourceForeground", "#5F5E61" },
        { "gitDecoration.untrackedResourceForeground", "#1a7f37" },
        { "icon.foreground", "#5F5E61" },
        { "input.background", "#ffffff" },
        { "input.border", "#848487" },
        { "input.foreground", "#131219" },
        { "input.placeholderForeground", "#6e7781" },
        { "keybindingLabel.foreground", "#131219" },
        { "list.activeSelectionBackground", "#afb8c133" },
        { "list.activeSelectionForeground", "#131219" },
        { "list.focusBackground", "#ddf4ff" },
        { "list.focusForeground", "#131219" },
        { "list.highlightForeground", "#8625D2" },
        { "list.hoverBackground", "#eaeef280" },
        { "list.hoverForeground", "#131219" },
        { "list.inactiveFocusBackground", "#ddf4ff" },
        { "list.inactiveSelectionBackground", "#afb8c133" },
        { "list.inactiveSelectionForeground", "#131219" },
        { "minimapSlider.activeBackground", "#8c959f47" },
        { "minimapSlider.background", "#8c959f33" },
        { "minimapSlider.hoverBackground", "#8c959f3d" },
        { "notificationCenterHeader.background", "#f6f8fa" },
        { "notificationCenterHeader.foreground", "#5F5E61" },
        { "notifications.background", "#ffffff" },
        { "notifications.border", "#848487" },
        { "notifications.foreground", "#131219" },
        { "notificationsErrorIcon.foreground", "#cf222e" },
        { "notificationsInfoIcon.foreground", "#8625D2" },
        { "notificationsWarningIcon.foreground", "#9a6700" },
        { "panel.background", "#f6f8fa" },
        { "panel.border", "#848487" },
        { "panelInput.border", "#848487" },
        { "panelTitle.activeBorder", "#fd8c73" },
        { "panelTitle.activeForeground", "#131219" },
        { "panelTitle.inactiveForeground", "#5F5E61" },
        { "pickerGroup.border", "#848487" },
        { "pickerGroup.foreground", "#5F5E61" },
        { "progressBar.background", "#8625D2" },
        { "quickInput.background", "#ffffff" },
        { "quickInput.foreground", "#131219" },
        { "scrollbar.shadow", "#6e778133" },
        { "scrollbarSlider.activeBackground", "#8c959f47" },
        { "scrollbarSlider.background", "#8c959f33" },
        { "scrollbarSlider.hoverBackground", "#8c959f3d" },
        { "settings.headerForeground", "#131219" },
        { "settings.modifiedItemIndicator", "#d4a72c66" },
        { "sideBar.background", "#f6f8fa" },
        { "sideBar.border", "#848487" },
        { "sideBar.foreground", "#131219" },
        { "sideBarSectionHeader.background", "#f6f8fa" },
        { "sideBarSectionHeader.border", "#848487" },
        { "sideBarSectionHeader.foreground", "#131219" },
        { "sideBarTitle.foreground", "#131219" },
        { "statusBar.background", "#ffffff" },
        { "statusBar.border", "#848487" },
        { "statusBar.debuggingBackground", "#cf222e" },
        { "statusBar.debuggingForeground", "#ffffff" },
        { "statusBar.focusBorder", "#8625D280" },
        { "statusBar.foreground", "#5F5E61" },
        { "statusBar.noFolderBackground", "#ffffff" },
        { "statusBarItem.activeBackground", "#1312191f" },
        { "statusBarItem.focusBorder", "#8625D2" },
        { "statusBarItem.hoverBackground", "#13121914" },
        { "statusBarItem.prominentBackground", "#afb8c133" },
        { "statusBarItem.remoteBackground", "#eaeef2" },
        { "statusBarItem.remoteForeground", "#131219" },
        { "symbolIcon.arrayForeground", "#953800" },
        { "symbolIcon.booleanForeground", "#0550ae" },
        { "symbolIcon.classForeground", "#953800" },
        { "symbolIcon.colorForeground", "#0a3069" },
        { "symbolIcon.constantForeground", "#116329" },
        { "symbolIcon.constructorForeground", "#3e1f79" },
        { "symbolIcon.enumeratorForeground", "#953800" },
        { "symbolIcon.enumeratorMemberForeground", "#0550ae" },
        { "symbolIcon.eventForeground", "#57606a" },
        { "symbolIcon.fieldForeground", "#953800" },
        { "symbolIcon.fileForeground", "#7d4e00" },
        { "symbolIcon.folderForeground", "#7d4e00" },
        { "symbolIcon.functionForeground", "#6639ba" },
        { "symbolIcon.interfaceForeground", "#953800" },
        { "symbolIcon.keyForeground", "#0550ae" },
        { "symbolIcon.keywordForeground", "#a40e26" },
        { "symbolIcon.methodForeground", "#6639ba" },
        { "symbolIcon.moduleForeground", "#a40e26" },
        { "symbolIcon.namespaceForeground", "#a40e26" },
        { "symbolIcon.nullForeground", "#0550ae" },
        { "symbolIcon.numberForeground", "#116329" },
        { "symbolIcon.objectForeground", "#953800" },
        { "symbolIcon.operatorForeground", "#0a3069" },
        { "symbolIcon.packageForeground", "#953800" },
        { "symbolIcon.propertyForeground", "#953800" },
        { "symbolIcon.referenceForeground", "#0550ae" },
        { "symbolIcon.snippetForeground", "#0550ae" },
        { "symbolIcon.stringForeground", "#0a3069" },
        { "symbolIcon.structForeground", "#953800" },
        { "symbolIcon.textForeground", "#0a3069" },
        { "symbolIcon.typeParameterForeground", "#0a3069" },
        { "symbolIcon.unitForeground", "#0550ae" },
        { "symbolIcon.variableForeground", "#953800" },
        { "tab.activeBackground", "#ffffff" },
        { "tab.activeBorder", "#ffffff" },
        { "tab.activeBorderTop", "#fd8c73" },
        { "tab.activeForeground", "#131219" },
        { "tab.border", "#848487" },
        { "tab.hoverBackground", "#ffffff" },
        { "tab.inactiveBackground", "#f6f8fa" },
        { "tab.inactiveForeground", "#5F5E61" },
        { "tab.unfocusedActiveBorder", "#ffffff" },
        { "tab.unfocusedActiveBorderTop", "#848487" },
        { "tab.unfocusedHoverBackground", "#eaeef280" },
        { "terminal.ansiBlack", "#24292f" },
        { "terminal.ansiBlue", "#8625D2" },
        { "terminal.ansiBrightBlack", "#57606a" },
        { "terminal.ansiBrightBlue", "#218bff" },
        { "terminal.ansiBrightCyan", "#3192aa" },
        { "terminal.ansiBrightGreen", "#1a7f37" },
        { "terminal.ansiBrightMagenta", "#a475f9" },
        { "terminal.ansiBrightRed", "#a40e26" },
        { "terminal.ansiBrightWhite", "#8c959f" },
        { "terminal.ansiBrightYellow", "#633c01" },
        { "terminal.ansiCyan", "#1b7c83" },
        { "terminal.ansiGreen", "#116329" },
        { "terminal.ansiMagenta", "#8250df" },
        { "terminal.ansiRed", "#cf222e" },
        { "terminal.ansiWhite", "#6e7781" },
        { "terminal.ansiYellow", "#4d2d00" },
        { "terminal.foreground", "#131219" },
        { "textBlockQuote.background", "#f6f8fa" },
        { "textBlockQuote.border", "#848487" },
        { "textCodeBlock.background", "#afb8c133" },
        { "textLink.activeForeground", "#8625D2" },
        { "textLink.foreground", "#8625D2" },
        { "textPreformat.foreground", "#5F5E61" },
        { "textSeparator.foreground", "#d8dee4" },
        { "titleBar.activeBackground", "#ffffff" },
        { "titleBar.activeForeground", "#5F5E61" },
        { "titleBar.border", "#848487" },
        { "titleBar.inactiveBackground", "#f6f8fa" },
        { "titleBar.inactiveForeground", "#5F5E61" },
        { "tree.indentGuidesStroke", "#d8dee4" },
    };
}