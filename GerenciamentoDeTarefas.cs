// Implementação básica de uma tarefa
public class TaskItem
{
    public string Title { get; set; }
    public bool IsCompleted { get; set; }
}

// Classe para o gerenciamento de tarefas
public class TaskManager
{
    private List<TaskItem> tasks = new List<TaskItem>();

    public void AddTask(string title)
    {
        tasks.Add(new TaskItem { Title = title, IsCompleted = false });
    }

    // Métodos para editar, excluir e marcar como concluída
}
