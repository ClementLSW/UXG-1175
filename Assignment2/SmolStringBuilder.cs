using System;

class SmolStringBuilder : IStringBuilder{
    // TODO
    public string String { get; set; }

    public void Append(string str) {
        str = str.ToLower();
        String += str;
    }

    public void Clear() {
        String = "";
    }
}
