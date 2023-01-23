using System;

class NormalStringBuilder : IStringBuilder {
    // TODO
    public string String { get; set; }

    public void Append(string str) {
        String += str;
    }

    public void Clear() {
        String = "";
    }
}
