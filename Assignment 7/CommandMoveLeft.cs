class CommandMoveLeft : Command {
    // TODO
    private Player m_player;
    public CommandMoveLeft(Player player) {
        m_player = player;
    }

    public void Execute() {
        m_player.MoveLeft();
    }

    public void Undo() {
        m_player.MoveRight();
    }
}
