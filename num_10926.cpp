/*
����
���ϴ� ����Ʈ�� ȸ�������� �ϴٰ� joonas��� ���̵� �̹� �����ϴ� ���� ���� �����. ���ϴ� ����� ??!�� ǥ���Ѵ�. ���ϰ� �����Ϸ��� �ϴ� ����Ʈ�� �̹� �����ϴ� ���̵� �־����� ��, ����� ǥ���ϴ� ���α׷��� �ۼ��Ͻÿ�.

�Է�
ù° �ٿ� ���ϰ� �����Ϸ��� �ϴ� ����Ʈ�� �̹� �����ϴ� ���̵� �־�����. ���̵�� ���ĺ� �ҹ��ڷθ� �̷���� ������, ���̴� 50�ڸ� ���� �ʴ´�.

���
ù° �ٿ� ������ ����� ����Ѵ�. ����� ���̵� �ڿ� ??!�� �ٿ��� ��Ÿ����.

���� �Է� 1
joonas
���� ��� 1
joonas??!

���� �Է� 2
baekjoon
���� ��� 2
baekjoon??!
*/
#include<iostream>
#include<cctype>
#include<string>

using namespace std;

//�迭 ũ��
const size_t MAX_LENGTH = 50;
//���� �迭�� size
size_t idlist_size = 2;

void Input()
{
	//�迭 �ʱ�ȭ
	string idlist[MAX_LENGTH] = { "joonas","baekjoon" };

	//���̵� �Է¹ޱ�
	string id;
	getline(cin, id);

	//���̵� �˻�
	for (size_t i = 0; i < idlist_size; i++)
	{
		if (idlist[i] == id)
		{
			cout << id << "??!" << endl;
			return;
		}
	}
	cout << id << endl;
	idlist[idlist_size] = id;
	idlist_size++;
	return;
}

int main()
{
	Input();
	return 0;
}