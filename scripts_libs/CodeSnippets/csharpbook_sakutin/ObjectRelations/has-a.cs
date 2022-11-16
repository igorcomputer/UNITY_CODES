/*

Has-a  - Когда один объект содержит другой

Предназначение этой связи может быть разное, один объект может 
просто ссылаться а может и делегировать ряд задач какому-то другому объекту.
 
*/

namespace relation_has_a {

    class User {
        public string Name;

        public User(string name) {
            Name = name;
        }
    }

    class List {
        public Task[] Tasks;

        public List(Task[] tasks) {
            Tasks = tasks;
        }
    }

    class Task {
        public User Worker;
        public string Description;

        public Task(User worker, string description) {
            Worker = worker;
            Description = description;
        }
    }

}