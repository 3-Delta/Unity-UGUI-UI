using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Behaviac.Design;
using Behaviac.Design.Attributes;
using ExamplePlugin.Properties;
using Behaviac.Design.Nodes;

namespace ExamplePlugin.Nodes
{
    // �����Զ���Behaviac��task�ڵ���ĵ�
    // http://www.behaviac.com/tutorial9_extendnodes/
    [NodeDesc("Actions:Kaclok", "AI_PlaySkill")]
    public class PlaySkill : Behaviac.Design.Nodes.Node
    {
        public PlaySkill() : base("AI_���ż���", "���ż���") { }
        public override string ExportClass { get { return "PlaySkill"; } }

        protected override void CloneProperties(Node newnode)
        {
            base.CloneProperties(newnode);
        }
        public override void CheckForErrors(BehaviorNode rootBehavior, List<ErrorCheck> result)
        {
            base.CheckForErrors(rootBehavior, result);
        }

        // ��������
    }
}