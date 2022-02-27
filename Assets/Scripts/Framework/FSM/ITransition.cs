namespace FSM {
    public interface ITransition : IName {
        IState from { get; }
        IState to { get; }

        // ����ת������һЩ��ʱ�ԵĲ���������һ������
        float OnTransitionProgress();

        // ����ת��
        void Enter();

        // �˳�ת��
        void Exit();

        void Update(float deltaTime);

        // �ܷ�ʼ����
        bool ShouldBegin();

        // �ܷ��������
        bool ShouleEnd();
    }
}
