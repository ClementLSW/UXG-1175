using System;

class BeegStringBuilder : IStringBuilder {
    public string String { get; set; }

    public void Append(string str) {
        str = str.ToUpper();
        String += str;
    }

    public void Clear() {
        String = "";
    }
}
