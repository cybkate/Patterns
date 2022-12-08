using System;
namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            ConcreteChristmasTree c =
            new ConcreteChristmasTree();
            ConcreteDecoratorA d1 =
            new ConcreteDecoratorA();
            ConcreteDecoratorB d2 =
            new ConcreteDecoratorB();
            ConcreteDecoratorC d3 =
            new ConcreteDecoratorC();
            d1.SetComponent(c);
            d1.SetColor("green");
            d1.Operation();
            d1.SetColor("blue");
            d1.Operation();
            d2.SetComponent(c);
            d2.SetSize("little one");
            d2.Operation();
            d3.SetComponent(c);
            d3.Operation();
            Console.Read();
        }
    }
    abstract class ChristmasTree
    {
        public abstract void Operation();
    }
    class ConcreteChristmasTree : ChristmasTree
    {
        public override void Operation()
        {
            Console.WriteLine("Omg added decoration: ");
        }
    }
    abstract class Decorator : ChristmasTree
    {
        protected ChristmasTree tree;
        public void SetComponent(ChristmasTree tree)
        {
            this.tree = tree;
        }
        public override void Operation()
        {
            if (tree != null)
            {
                tree.Operation();
            }
        }
    }
    class ConcreteDecoratorA : Decorator
    {
        private string addedState;
        private string color;
        public void SetColor(string color)
        {
            this.color = color;
        }
        public override void Operation()
        {
            base.Operation();
            addedState = " Christmas Bauble";
            Console.WriteLine(color + addedState);
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        private string addedState;
        private string size;
        public void SetSize(string size)
        {
            this.size = size;
        }
        public override void Operation()
        {
            base.Operation();
            addedState = " Tinsel";
            Console.WriteLine(size + addedState);
        }
    }
    class ConcreteDecoratorC : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine(" Christmas Star");
            AddedBehavior();
        }
        void AddedBehavior()
        {
            Console.WriteLine("Christmas tree can glow)");
        }
    }
}