using System.Diagnostics;
using System.Windows.Input;

// Based off the example in https://learn.microsoft.com/en-us/archive/msdn-magazine/2009/february/patterns-wpf-apps-with-the-model-view-viewmodel-design-pattern
public class RelayCommand : ICommand
{
	readonly Action<object> _execute;
	readonly Predicate<object> _canExecute;


	public RelayCommand(Action<object> execute) : this(execute, null) { }
	public RelayCommand(Action<object> execute, Predicate<object> canExecute)
	{
		if (execute == null)
			throw new ArgumentNullException("execute");
		_execute = execute; _canExecute = canExecute;
	}

	[DebuggerStepThrough]
	public bool CanExecute(object parameter)
	{
		return _canExecute == null ? true : _canExecute(parameter);
	}
	public event EventHandler CanExecuteChanged
	{
		add { CommandManager.RequerySuggested += value; }
		remove { CommandManager.RequerySuggested -= value; }
	}
	public void Execute(object parameter) { _execute(parameter); }

}