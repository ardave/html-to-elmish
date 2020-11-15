module HtmlConverter.References

[<RequireQualifiedAccess>]
type AttributeType =
    | String
    | Int
    | Float
    | Obj
    | Func
    | Bool

type FSharpName = string
type HtmlName = string

let attributes : (FSharpName * HtmlName * AttributeType) list =
    [ // EventListener
      "_onCut", "onCut", AttributeType.Func
      "_onPaste", "onPaste", AttributeType.Func
      "_onCompositionEnd", "onCompositionEnd", AttributeType.Func
      "_onCompositionStart", "onCompositionStart", AttributeType.Func
      "_onCopy", "onCopy", AttributeType.Func
      "_onCompositionUpdate", "onCompositionUpdate", AttributeType.Func
      "_onFocus", "onFocus", AttributeType.Func
      "_onBlur", "onBlur", AttributeType.Func
      "_onChange", "onChange", AttributeType.Func
      "_onInput", "onInput", AttributeType.Func
      "_onSubmit", "onSubmit", AttributeType.Func
      "_onLoad", "onLoad", AttributeType.Func
      "_onError", "onError", AttributeType.Func
      "_onKeyDown", "onKeyDown", AttributeType.Func
      "_onKeyPress", "onKeyPress", AttributeType.Func
      "_onKeyUp", "onKeyUp", AttributeType.Func
      "_onAbort", "onAbort", AttributeType.Func
      "_onCanPlay", "onCanPlay", AttributeType.Func
      "_onCanPlayThrough", "onCanPlayThrough", AttributeType.Func
      "_onDurationChange", "onDurationChange", AttributeType.Func
      "_onEmptied", "onEmptied", AttributeType.Func
      "_onEncrypted", "onEncrypted", AttributeType.Func
      "_onEnded", "onEnded", AttributeType.Func
      "_onLoadedData", "onLoadedData", AttributeType.Func
      "_onLoadedMetadata", "onLoadedMetadata", AttributeType.Func
      "_onLoadStart", "onLoadStart", AttributeType.Func
      "_onPause", "onPause", AttributeType.Func
      "_onPlay", "onPlay", AttributeType.Func
      "_onPlaying", "onPlaying", AttributeType.Func
      "_onProgress", "onProgress", AttributeType.Func
      "_onRateChange", "onRateChange", AttributeType.Func
      "_onSeeked", "onSeeked", AttributeType.Func
      "_onSeeking", "onSeeking", AttributeType.Func
      "_onStalled", "onStalled", AttributeType.Func
      "_onSuspend", "onSuspend", AttributeType.Func
      "_onTimeUpdate", "onTimeUpdate", AttributeType.Func
      "_onVolumeChange", "onVolumeChange", AttributeType.Func
      "_onWaiting", "onWaiting", AttributeType.Func
      "_onClick", "onClick", AttributeType.Func
      "_onContextMenu", "onContextMenu", AttributeType.Func
      "_onDoubleClick", "onDoubleClick", AttributeType.Func
      "_onDrag", "onDrag", AttributeType.Func
      "_onDragEnd", "onDragEnd", AttributeType.Func
      "_onDragEnter", "onDragEnter", AttributeType.Func
      "_onDragExit", "onDragExit", AttributeType.Func
      "_onDragLeave", "onDragLeave", AttributeType.Func
      "_onDragOver", "onDragOver", AttributeType.Func
      "_onDragStart", "onDragStart", AttributeType.Func
      "_onDrop", "onDrop", AttributeType.Func
      "_onMouseDown", "onMouseDown", AttributeType.Func
      "_onMouseEnter", "onMouseEnter", AttributeType.Func
      "_onMouseLeave", "onMouseLeave", AttributeType.Func
      "_onMouseMove", "onMouseMove", AttributeType.Func
      "_onMouseOut", "onMouseOut", AttributeType.Func
      "_onMouseOver", "onMouseOver", AttributeType.Func
      "_onMouseUp", "onMouseUp", AttributeType.Func
      "_onSelect", "onSelect", AttributeType.Func
      "_onTouchCancel", "onTouchCancel", AttributeType.Func
      "_onTouchEnd", "onTouchEnd", AttributeType.Func
      "_onTouchMove", "onTouchMove", AttributeType.Func
      "_onTouchStart", "onTouchStart", AttributeType.Func
      "_onScroll", "onScroll", AttributeType.Func
      "_onWheel", "onWheel", AttributeType.Func
      "_onAnimationStart", "onAnimationStart", AttributeType.Func
      "_onAnimationEnd", "onAnimationEnd", AttributeType.Func
      "_onAnimationIteration", "onAnimationIteration", AttributeType.Func
      "_onTransitionEnd", "onTransitionEnd", AttributeType.Func
      // HTMLAttributes
      "_defaultChecked", "defaultChecked", AttributeType.Bool
      "_defaultValue", "defaultValue", AttributeType.String
      "_accept", "accept", AttributeType.String
      "_acceptCharset", "acceptCharset", AttributeType.String
      "_accessKey", "accessKey", AttributeType.String
      "_action", "action", AttributeType.String
      "_allowFullScreen", "allowFullScreen", AttributeType.Bool
      "_allowTransparency", "allowTransparency", AttributeType.Bool
      "_alt", "alt", AttributeType.String
      "_ariaHasPopup", "aria-haspopup", AttributeType.Bool
      "_ariaExpanded", "aria-expanded", AttributeType.Bool
      "_async", "async", AttributeType.Bool
      "_autoComplete", "autoComplete", AttributeType.String
      "_autoFocus", "autoFocus", AttributeType.Bool
      "_autoPlay", "autoPlay", AttributeType.Bool
      "_capture", "capture", AttributeType.Bool
      "_cellPadding", "cellPadding", AttributeType.Obj
      "_cellSpacing", "cellSpacing", AttributeType.Obj
      "_charSet", "charSet", AttributeType.String
      "_challenge", "challenge", AttributeType.String
      "_checked", "checked", AttributeType.Bool
      "_classID", "classID", AttributeType.String
      "_className", "className", AttributeType.String
      "_class", "class",  AttributeType.String
      "_cols", "cols", AttributeType.Float
      "_colSpan", "colSpan", AttributeType.Float
      "_content", "content", AttributeType.String
      "_contentEditable", "contentEditable", AttributeType.Bool
      "_contextMenu", "contextMenu", AttributeType.String
      "_controls", "controls", AttributeType.Bool
      "_coords", "coords", AttributeType.String
      "_crossOrigin", "crossOrigin", AttributeType.String
      "_data_name", "data-name", AttributeType.String
      "_data_wait", "data-wait", AttributeType.String
      "_dataToggle", "data-toggle", AttributeType.String
      "_dateTime", "dateTime", AttributeType.String
      "_default", "default", AttributeType.Bool
      "_defer", "defer", AttributeType.Bool
      "_dir", "dir", AttributeType.String
      "_disabled", "disabled", AttributeType.Bool
      "_download", "download", AttributeType.Obj
      "_draggable", "draggable", AttributeType.Bool
      "_encType", "encType", AttributeType.String
      "_for", "for", AttributeType.String
      "_form", "form", AttributeType.String
      "_formAction", "formAction", AttributeType.String
      "_formEncType", "formEncType", AttributeType.String
      "_formMethod", "formMethod", AttributeType.String
      "_formNoValidate", "formNoValidate", AttributeType.Bool
      "_formTarget", "formTarget", AttributeType.String
      "_frameBorder", "frameBorder", AttributeType.Obj
      "_headers", "headers", AttributeType.String
      "_height", "height", AttributeType.Obj
      "_hidden", "hidden", AttributeType.Bool
      "_high", "high", AttributeType.Float
      "_href", "href", AttributeType.String
      "_hrefLang", "hrefLang", AttributeType.String
      "_htmlFor", "htmlFor", AttributeType.String
      "_httpEquiv", "httpEquiv", AttributeType.String
      "_icon", "icon", AttributeType.String
      "_id", "id", AttributeType.String
      "_inputMode", "inputMode", AttributeType.String
      "_integrity", "integrity", AttributeType.String
      "_is", "is", AttributeType.String
      "_keyParams", "keyParams", AttributeType.String
      "_keyType", "keyType", AttributeType.String
      "_kind", "kind", AttributeType.String
      "_label", "label", AttributeType.String
      "_lang", "lang", AttributeType.String
      "_list", "list", AttributeType.String
      "_loop", "loop", AttributeType.Bool
      "_low", "low", AttributeType.Float
      "_manifest", "manifest", AttributeType.String
      "_marginHeight", "marginHeight", AttributeType.Float
      "_marginWidth", "marginWidth", AttributeType.Float
      "_max", "max", AttributeType.Obj
      "_maxlength", "maxLength", AttributeType.String
      "_media", "media", AttributeType.String
      "_mediaGroup", "mediaGroup", AttributeType.String
      "_method", "method", AttributeType.String
      "_min", "min", AttributeType.Obj
      "_minlength", "minLength", AttributeType.String
      "_multiple", "multiple", AttributeType.Bool
      "_muted", "muted", AttributeType.Bool
      "_name", "name", AttributeType.String
      "_noValidate", "noValidate", AttributeType.Bool
      "_open", "open", AttributeType.Bool
      "_optimum", "pptimum", AttributeType.Float
      "_pattern", "pattern", AttributeType.String
      "_placeholder", "placeholder", AttributeType.String
      "_poster", "poster", AttributeType.String
      "_preload", "preload", AttributeType.String
      "_radioGroup", "radioGroup", AttributeType.String
      "_readOnly", "readOnly", AttributeType.Bool
      "_rel", "rel", AttributeType.String
      "_required", "required", AttributeType.Bool
      "_role", "role", AttributeType.String
      "_rows", "rows", AttributeType.Float
      "_rowSpan", "rowSpan", AttributeType.Float
      "_sandbox", "sandbox", AttributeType.String
      "_scope", "scope", AttributeType.String
      "_scoped", "scoped", AttributeType.Bool
      "_scrolling", "scrolling", AttributeType.String
      "_seamless", "seamless", AttributeType.Bool
      "_selected", "selected", AttributeType.Bool
      "_shape", "shape", AttributeType.String
      "_size", "size", AttributeType.Float
      "_sizes", "sizes", AttributeType.String
      "_span", "span", AttributeType.Float
      "_spellCheck", "spellCheck", AttributeType.Bool
      "_src", "src", AttributeType.String
      "_srcDoc", "srcDoc", AttributeType.String
      "_srcLang", "srcLang", AttributeType.String
      "_srcSet", "srcSet", AttributeType.String
      "_start", "start", AttributeType.Float
      "_step", "step", AttributeType.Obj
      "_summary", "summary", AttributeType.String
      "_tabIndex", "tabIndex", AttributeType.Float
      "_target", "target", AttributeType.String
      "_title", "title", AttributeType.String
      "_type", "type", AttributeType.String
      "_useMap", "useMap", AttributeType.String
      "_value", "value", AttributeType.String
      "_width", "width", AttributeType.Obj
      "_wmode", "wmode", AttributeType.String
      "_wrap", "wrap", AttributeType.String
      "_about", "about", AttributeType.String
      "_datatype", "datatype", AttributeType.String
      "_inlist", "inlist", AttributeType.Obj
      "_prefix", "prefix", AttributeType.String
      "_property", "property", AttributeType.String
      "_resource", "resource", AttributeType.String
      "_typeof", "typeof", AttributeType.String
      "_vocab", "vocab", AttributeType.String
      "_autoCapitalize", "autoCapitalize", AttributeType.String
      "_autoCorrect", "autoCorrect", AttributeType.String
      "_autoSave", "autoSave", AttributeType.String
      "_itemProp", "itemProp", AttributeType.String
      "_itemScope", "itemScope", AttributeType.Bool
      "_itemType", "itemType", AttributeType.String
      "_itemID", "itemID", AttributeType.String
      "_itemRef", "itemRef", AttributeType.String
      "_results", "results", AttributeType.Float
      "_security", "security", AttributeType.String
      "_unselectable", "unselectable", AttributeType.Bool
    //   "Style", "style" of CSSProp list
    //   "Data", "data" of string * obj
    //| Custom of string * obj
       ]

let cssProps : string array =
    [| "AlignContent"; "AlignItems"; "AlignSelf"; "AlignmentAdjust"; "AlignmentBaseline"; "All"; "Animation"; "AnimationDelay"; "AnimationDirection"; "AnimationDuration";
      "AnimationFillMode"; "AnimationIterationCount"; "AnimationName"; "AnimationPlayState"; "AnimationTimingFunction"; "Appearance"; "BackfaceVisibility"; "Background";
      "BackgroundAttachment"; "BackgroundBlendMode"; "BackgroundClip"; "BackgroundColor"; "BackgroundComposite"; "BackgroundImage"; "BackgroundOrigin"; "BackgroundPosition";
      "BackgroundPositionX"; "BackgroundPositionY"; "BackgroundRepeat"; "BackgroundSize"; "BaselineShift"; "Behavior"; "BlockSize"; "Border"; "BorderBlockEnd"; "BorderBlockEndColor";
      "BorderBlockEndStyle"; "BorderBlockEndWidth"; "BorderBlockStart"; "BorderBlockStartColor"; "BorderBlockStartStyle"; "BorderBlockStartWidth"; "BorderBottom"; "BorderBottomColor";
      "BorderBottomLeftRadius"; "BorderBottomRightRadius"; "BorderBottomStyle"; "BorderBottomWidth"; "BorderCollapse"; "BorderColor"; "BorderCornerShape"; "BorderImage";
      "BorderImageOutset"; "BorderImageRepeat"; "BorderImageSlice"; "BorderImageSource"; "BorderImageWidth"; "BorderInlineEnd"; "BorderInlineEndColor"; "BorderInlineEndStyle";
      "BorderInlineEndWidth"; "BorderInlineStart"; "BorderInlineStartColor"; "BorderInlineStartStyle"; "BorderInlineStartWidth"; "BorderLeft"; "BorderLeftColor"; "BorderLeftStyle";
      "BorderLeftWidth"; "BorderRadius"; "BorderRight"; "BorderRightColor"; "BorderRightStyle"; "BorderRightWidth"; "BorderSpacing"; "BorderStyle"; "BorderTop"; "BorderTopColor";
      "BorderTopLeftRadius"; "BorderTopRightRadius"; "BorderTopStyle"; "BorderTopWidth"; "BorderWidth"; "Bottom"; "BoxAlign"; "BoxDecorationBreak"; "BoxDirection"; "BoxFlex";
      "BoxFlexGroup"; "BoxLineProgression"; "BoxLines"; "BoxOrdinalGroup"; "BoxShadow"; "BoxSizing"; "BreakAfter"; "BreakBefore"; "BreakInside"; "CaptionSide"; "CaretColor"; "Clear";
      "Clip"; "ClipPath"; "ClipRule"; "Color"; "ColorInterpolation"; "ColorInterpolationFilters"; "ColorProfile"; "ColorRendering"; "ColumnCount"; "ColumnFill"; "ColumnGap"; "ColumnRule";
      "ColumnRuleColor"; "ColumnRuleStyle"; "ColumnRuleWidth"; "ColumnSpan"; "ColumnWidth"; "Columns"; "Content"; "CounterIncrement"; "CounterReset"; "Cue"; "CueAfter"; "Cursor"; "Direction";
      "Display"; "DominantBaseline"; "EmptyCells"; "EnableBackground"; "Fill"; "FillOpacity"; "FillRule"; "Filter"; "Flex"; "FlexAlign"; "FlexBasis"; "FlexDirection"; "FlexFlow"; "FlexGrow";
      "FlexItemAlign"; "FlexLinePack"; "FlexOrder"; "FlexShrink"; "FlexWrap"; "Float"; "FloodColor"; "FloodOpacity"; "FlowFrom"; "Font"; "FontFamily"; "FontFeatureSettings"; "FontKerning";
      "FontLanguageOverride"; "FontSize"; "FontSizeAdjust"; "FontStretch"; "FontStyle"; "FontSynthesis"; "FontVariant"; "FontVariantAlternates"; "FontVariantCaps"; "FontVariantEastAsian";
      "FontVariantLigatures"; "FontVariantNumeric"; "FontVariantPosition"; "FontWeight"; "GlyphOrientationHorizontal"; "GlyphOrientationVertical"; "Grid"; "GridArea"; "GridAutoColumns";
      "GridAutoFlow"; "GridAutoRows"; "GridColumn"; "GridColumnEnd"; "GridColumnGap"; "GridColumnStart"; "GridGap"; "GridRow"; "GridRowEnd"; "GridRowGap"; "GridRowPosition"; "GridRowSpan";
      "GridRowStart"; "GridTemplate"; "GridTemplateAreas"; "GridTemplateColumns"; "GridTemplateRows"; "HangingPunctuation"; "Height"; "HyphenateLimitChars"; "HyphenateLimitLines";
      "HyphenateLimitZone"; "Hyphens"; "ImageOrientation"; "ImageRendering"; "ImageResolution"; "ImeMode"; "InlineSize"; "Isolation"; "JustifyContent"; "Kerning"; "LayoutGrid"; "LayoutGridChar";
      "LayoutGridLine"; "LayoutGridMode"; "LayoutGridType"; "Left"; "LetterSpacing"; "LightingColor"; "LineBreak"; "LineClamp"; "LineHeight"; "ListStyle"; "ListStyleImage"; "ListStylePosition";
      "ListStyleType"; "Margin"; "MarginBlockEnd"; "MarginBlockStart"; "MarginBottom"; "MarginInlineEnd"; "MarginInlineStart"; "MarginLeft"; "MarginRight"; "MarginTop"; "MarkerEnd";
      "MarkerMid"; "MarkerStart"; "MarqueeDirection"; "MarqueeStyle"; "Mask"; "MaskBorder"; "MaskBorderRepeat"; "MaskBorderSlice"; "MaskBorderSource"; "MaskBorderWidth"; "MaskClip";
      "MaskComposite"; "MaskImage"; "MaskMode"; "MaskOrigin"; "MaskPosition"; "MaskRepeat"; "MaskSize"; "MaskType"; "MaxFontSize"; "MaxHeight"; "MaxWidth"; "MinBlockSize"; "MinHeight";
      "MinInlineSize"; "MinWidth"; "MixBlendMode"; "ObjectFit"; "ObjectPosition"; "OffsetBlockEnd"; "OffsetBlockStart"; "OffsetInlineEnd"; "OffsetInlineStart"; "Opacity"; "Order";
      "Orphans"; "Outline"; "OutlineColor"; "OutlineOffset"; "OutlineStyle"; "OutlineWidth"; "Overflow"; "OverflowStyle"; "OverflowWrap"; "OverflowX"; "OverflowY"; "Padding";
      "PaddingBlockEnd"; "PaddingBlockStart"; "PaddingBottom"; "PaddingInlineEnd"; "PaddingInlineStart"; "PaddingLeft"; "PaddingRight"; "PaddingTop"; "PageBreakAfter"; "PageBreakBefore";
      "PageBreakInside"; "Pause"; "PauseAfter"; "PauseBefore"; "Perspective"; "PerspectiveOrigin"; "PointerEvents"; "Position"; "PunctuationTrim"; "Quotes"; "RegionFragment"; "Resize";
      "RestAfter"; "RestBefore"; "Right"; "RubyAlign"; "RubyMerge"; "RubyPosition"; "ScrollBehavior"; "ScrollSnapCoordinate"; "ScrollSnapDestination"; "ScrollSnapType"; "ShapeImageThreshold";
      "ShapeInside"; "ShapeMargin"; "ShapeOutside"; "ShapeRendering"; "Speak"; "SpeakAs"; "StopColor"; "StopOpacity"; "Stroke"; "StrokeDasharray"; "StrokeDashoffset"; "StrokeLinecap";
      "StrokeLinejoin"; "StrokeMiterlimit"; "StrokeOpacity"; "StrokeWidth"; "TabSize"; "TableLayout"; "TextAlign"; "TextAlignLast"; "TextAnchor"; "TextCombineUpright"; "TextDecoration";
      "TextDecorationColor"; "TextDecorationLine"; "TextDecorationLineThrough"; "TextDecorationNone"; "TextDecorationOverline"; "TextDecorationSkip"; "TextDecorationStyle";
      "TextDecorationUnderline"; "TextEmphasis"; "TextEmphasisColor"; "TextEmphasisPosition"; "TextEmphasisStyle"; "TextHeight"; "TextIndent"; "TextJustify"; "TextJustifyTrim";
      "TextKashidaSpace"; "TextLineThrough"; "TextLineThroughColor"; "TextLineThroughMode"; "TextLineThroughStyle"; "TextLineThroughWidth"; "TextOrientation"; "TextOverflow"; "TextOverline";
      "TextOverlineColor"; "TextOverlineMode"; "TextOverlineStyle"; "TextOverlineWidth"; "TextRendering"; "TextScript"; "TextShadow"; "TextTransform"; "TextUnderlinePosition"; "TextUnderlineStyle";
      "Top"; "TouchAction"; "Transform"; "TransformBox"; "TransformOrigin"; "TransformOriginZ"; "TransformStyle"; "Transition"; "TransitionDelay"; "TransitionDuration"; "TransitionProperty";
      "TransitionTimingFunction"; "UnicodeBidi"; "UnicodeRange"; "UserFocus"; "UserInput"; "VerticalAlign"; "Visibility"; "VoiceBalance"; "VoiceDuration"; "VoiceFamily"; "VoicePitch";
      "VoiceRange"; "VoiceRate"; "VoiceStress"; "VoiceVolume"; "WhiteSpace"; "WhiteSpaceTreatment"; "Widows"; "Width"; "WillChange"; "WordBreak"; "WordSpacing"; "WordWrap"; "WrapFlow";
      "WrapMargin"; "WrapOption"; "WritingMode"; "ZIndex"; "Zoom" |]
