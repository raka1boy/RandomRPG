using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
namespace RandomRPG
{
    internal class RendererState
    {
        RendererState() { }
        private List<IRenderable> objects = new List<IRenderable>();
        public void NextFrame()
        {
            char[] buf = new char[Console.WindowHeight * Console.WindowWidth];

        }
        public void AddObjectToRenderPipeline(IRenderable obj)
        {
            if(objects.Count == 0)
            {
                objects.Add(obj);
                return;
            }
            
        }
    }
    interface IRenderable : IComparable<IRenderable>
    {
        int getLayering(); //ОБЯЗАТЕЛЬНО должен возвращать константное значение приоритета рендера
        public void Render(ref char[] buf);
        //public void RenderAt(out char[] buf, Vector2 left_top_pos);
        public bool IsVisible();
        public int CompareTo(IRenderable other)
        {
            if (getLayering() >= other.getLayering())
                return getLayering();
            else
                 return other.getLayering();
        }

    }

    public struct ScreenFiller : IRenderable
    {
        public char Character {get;set;}
        public readonly int getLayering() => 0;
        public readonly bool IsVisible() => true; // мы всегда будем видеть филлер
        public void Render(ref char[] buf)
        {
            for (int i = 0; i < buf.Length; i++)
            {
                buf[i] = Character;
            }
        }
    }
}
