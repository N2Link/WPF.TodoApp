namespace TodoApp.UI.Commands
{
    using System.Windows.Input;
    class RelayCommand : ICommand
    {
        private readonly Action<object?> execute;
        private readonly Predicate<object?>? canExecute;

        public RelayCommand(Action<object?> execute, Predicate<object?>? canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <inheritdoc/>
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <inheritdoc/>
        public bool CanExecute(object? parameter)
        {
            return this.canExecute is null || this.canExecute(parameter);
        }

        /// <inheritdoc/>
        public void Execute(object? parameter)
        {
            this.execute(parameter);
        }
    }
}
