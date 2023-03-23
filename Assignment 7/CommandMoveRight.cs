class CommandMoveRight : Command {
    // TODO
    private Player m_player;
    public CommandMoveRight(Player player) {
        m_player = player;
    }

    public void Execute() {
        m_player.MoveRight();
    }

    public void Undo() {
        m_player.MoveLeft();
    }
}
