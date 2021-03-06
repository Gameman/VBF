﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace VBF.MiniSharp.Ast
{
    public class Program : AstNode
    {
        public MainClass MainClass { get; private set; }
        public ReadOnlyCollection<ClassDecl> Classes { get; private set; }

        public Program(MainClass mainClass, IList<ClassDecl> classes)
        {
            MainClass = mainClass;
            Classes = new ReadOnlyCollection<ClassDecl>(classes);
        }

        public override T Accept<T>(IAstVisitor<T> visitor)
        {
            return visitor.VisitProgram(this);
        }
    }
}
