using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trees {
    public class TreeNode<T> {
        public T Data {get; set;}
        // atributo recursivo
        public TreeNode<T> Parent {get; set;}
        // lista com chamada de tipo recursivo
        public List<TreeNode<T>> Children {get; set;}
        // níveis da árvore
        public int GetHeight() {
            int height = 1;
            TreeNode<T> current = this;
            while(current.Parent != null) {
                height++; // +1
                current = current.Parent;
            }
            return height;
        }
    }
}