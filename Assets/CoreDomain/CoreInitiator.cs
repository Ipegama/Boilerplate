using System;
using System.Threading;
using UnityEngine;
using Zenject;

namespace IpegamaGames
{
    public class CoreInitiator : MonoBehaviour
    {
        [Inject]
        private void Setup()
        {

        }

        private void Start()
        {
            _ = InitEntryPoint(CancellationTokenSource.CreateLinkedTokenSource(Application.exitCancellationToken));
        }

        private async Awaitable InitEntryPoint(CancellationTokenSource cancellationTokenSource)
        {
            try
            {
                UpdateApplicationSettings();
                //loadingScreen.Show();
                InitializeServices();
                await LoadGameScene(cancellationTokenSource);
            }
            catch (OperationCanceledException)
            {
                LogService.Log("Operation init core was cancelled");
            }
            catch (Exception e)
            {
                LogService.LogError(e.Message);
                throw;
            }
            //loadingScreen.Hide();
        }
        private void UpdateApplicationSettings()
        {
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
            Application.targetFrameRate = 60;
        }
        private void InitializeServices()
        {

        }
        private async Awaitable LoadGameScene(CancellationTokenSource cancellationTokenSource)
        {

        }
    }
}
