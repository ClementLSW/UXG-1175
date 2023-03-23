class CommandMoveDown : Command {
    // TODO
    private Player m_player;
    public CommandMoveDown(Player player) {
        m_player = player;
    }

    public void Execute() {
        m_player.MoveDown();
    }

    public void Undo() {
        m_player.MoveUp();
    }
}
