class CommandMoveUp : Command {
    // TODO
    private Player m_player;
    public CommandMoveUp(Player player) {
        m_player = player;
    }

    public void Execute() {
        m_player.MoveUp();
    }

    public void Undo() {
        m_player.MoveDown();
    }
}
