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
    // [NodeDesc("Composites:Sequences", NodeIcon.Sequence)] ������ϵͼ
    [NodeDesc("Actions:Kaclok", "AI_PlayAnimation")]
    public class PlayAnimation : Behaviac.Design.Nodes.Node
    {
        public PlayAnimation() : base("AI_���Ŷ���", "���Ŷ���")
        {
            _exportName = "PlayAnimation";
        }
        public override string ExportClass { get { return "PlayAnimation"; } }

        protected override void CloneProperties(Node newnode)
        {
        }
        public override void CheckForErrors(BehaviorNode rootBehavior, List<ErrorCheck> result)
        {
            base.CheckForErrors(rootBehavior, result);
        }

        // ��������
        private RightValueDef _useTime = new RightValueDef(new VariableDef(false));
        [DesignerRightValueEnum("useTime", "useTime", "CategoryBasic", DesignerProperty.DisplayMode.Parameter, 1, DesignerProperty.DesignerFlags.NoFlags, DesignerPropertyEnum.AllowStyles.ConstAttributesMethod, MethodType.Getter, "", "", ValueTypes.Float)]
        public RightValueDef useTime
        {
            get { return _useTime; }
            set { _useTime = value; }
        }
        private RightValueDef _stateName = new RightValueDef(new VariableDef("idle"));
        [DesignerRightValueEnum("stateName", "stateName", "CategoryBasic", DesignerProperty.DisplayMode.Parameter, 3, DesignerProperty.DesignerFlags.NoFlags, DesignerPropertyEnum.AllowStyles.ConstAttributesMethod, MethodType.Getter, "", "", ValueTypes.Float)]
        public RightValueDef stateName
        {
            get { return _stateName; }
            set { _stateName = value; }
        }
    }
}