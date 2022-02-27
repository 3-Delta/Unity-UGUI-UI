using System.Collections.Generic;

// Created by kaclok at 2017/06/11-14:20:25 Sunday on pc: KACLOK.
// Copyright@nullgame`s testgame. All rights reserved.

/// <summary>
/// ״̬���ɽӿ�
/// </summary>
namespace FSM
{
    public interface ITransition : IName
    {
        IState from { get;}
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
