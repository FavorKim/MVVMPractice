using System.ComponentModel;
using ViewModel.Extensions;
using UnityEngine;
using UnityEngine.UI;

public class TopLeftUIView : MonoBehaviour
{
    [SerializeField] Text Text_Name;
    [SerializeField] Text Text_Level;
    [SerializeField] Image Img_Icon;

    // 뷰모델을 갖게된다
    private TopLeftUIViewModel m_viewModel;

    private void OnEnable()
    {
        if (m_viewModel == null)
        {
            m_viewModel = new TopLeftUIViewModel();
            m_viewModel.PropertyChanged += OnPropertyChanged;
            m_viewModel.RegisterEventOnEnable();
            m_viewModel.RefreshViewModel();
            
        }
    }

    private void OnDisable()
    {
        if (m_viewModel != null)
        {
            m_viewModel.UnRegisterEventOnDisable();
            m_viewModel.PropertyChanged -= OnPropertyChanged;
            m_viewModel = null;
        }
    }

    // View의 관한 모든 처리를 아래의 코드에 확장 가능
    private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
    {
        switch (args.PropertyName)
        {
            case nameof(m_viewModel.Name):
                Text_Name.text = $"Name : {m_viewModel.Name}";
                // Name View의 처리
                break;
            case nameof(m_viewModel.Level):
                Text_Level.text = $"LV : {m_viewModel.Level}";
                // Level View의 처리
                break;
            case nameof(m_viewModel.IconName):
                // IconName View의 처리
                break;
        }
    }


}
