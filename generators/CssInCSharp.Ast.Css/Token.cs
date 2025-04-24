namespace CssInCSharp.Ast.Css;

public class Token
{
    public int tn;
    public int ln;
    public int col;
    public string type;
    public string value;
    public int stylesheet_child;
    public int sc_child;
    public int ws_last;
    public int atrule_type;
    public int selectorsGroupEnd;
    public int selectorsGroupSelectorCount;
    public int selectorsGroupDelimCount;
    public int right;
    public int bd_type;
    public bool ws;
    public int? atrule_l;
    public int ident_last;
    public int selectorEnd;
    public int tsets_end;
    public int atrulers_child;
    public int atrulers_end;
    public int compoundSelectorType;
    public int combinatorType;
    public int tset_child;
    public int compoundSelectorEnd;
    public int any_child;
    public int class_l;
    public int classEnd;
    public int attributeSelectorType;
    public int keyframesSelectorType;
    public int number_l;
    public int namePrefixType;
    public int pseudoElementType;
    public int pseudoClassType;
    public int urangeEnd;
    public int attributeMatchType;
    public int bd_kind;
    public int propertyType;
    public int value_end;
    public int value_child;
    public int progid_end;
    public int importantEnd;
    public int argument_child;
    public int left;
    public bool sc;
    public int sc_last;

    public override string ToString()
    {
        return $"type: '{type}', value: '{value}'";
    }
}
