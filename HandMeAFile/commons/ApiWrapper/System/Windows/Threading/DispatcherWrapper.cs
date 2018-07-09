using System;
using System.Threading;
using System.Windows.Threading;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Threading
{
    public class DispatcherWrapper : IDispatcher
    {
        /// <summary>Bestimmt, ob der aufrufende Thread diesem <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>true, wenn der aufrufende Thread diesem <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist, andernfalls false.</returns>
        public bool CheckAccess()
        {
            return m_orgDispatcher.CheckAccess();
        }

        /// <summary>Bestimmt, ob der aufrufende Thread auf dieses <see cref="T:System.Windows.Threading.Dispatcher" /> zugreifen kann.</summary>
        /// <exception cref="T:System.InvalidOperationException">Der aufrufende Thread kann nicht auf diesen <see cref="T:System.Windows.Threading.Dispatcher" /> zugreifen.</exception>
        public void VerifyAccess()
        {
            m_orgDispatcher.VerifyAccess();
        }

        /// <summary>Initiiert ein asynchrones Beenden des <see cref="T:System.Windows.Threading.Dispatcher" />.</summary>
        /// <param name="priority">Die Priorit�t, bei der mit dem Beenden des Verteilers begonnen wird.</param>
        public void BeginInvokeShutdown(DispatcherPriority priority)
        {
            m_orgDispatcher.BeginInvokeShutdown(priority);
        }

        /// <summary>Initiiert die synchrone Beendigung des <see cref="T:System.Windows.Threading.Dispatcher" />.</summary>
        public void InvokeShutdown()
        {
            m_orgDispatcher.InvokeShutdown();
        }

        /// <summary>F�hrt den angegebenen Delegaten asynchron mit der angegebenen Priorit�t auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Ein Objekt, das unmittelbar nach dem Aufruf von <see cref="Overload:System.Windows.Threading.Dispatcher.BeginInvoke" /> zur�ckgegeben wird und f�r die Interaktion mit dem Delegaten verwendet werden kann, w�hrend im Delegaten die Ausf�hrung einer Aufgabe in der Warteschlange steht.</returns>
        /// <param name="priority">Die Priorit�t, relativ zu den anderen anstehenden Operationen in der <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange, mit der die angegebene Methode aufgerufen wird.</param>
        /// <param name="method">Der Delegat zu einer Methode, die keine Argumente erwartet und in die <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange gestellt wird.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="method" /> ist null.</exception>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// <paramref name="priority" /> ist kein g�ltiger <see cref="T:System.Windows.Threading.DispatcherPriority" />.</exception>
        public DispatcherOperation BeginInvoke(DispatcherPriority priority, Delegate method)
        {
            return m_orgDispatcher.BeginInvoke(priority, method);
        }

        /// <summary>F�hrt den angegebenen Delegaten asynchron mit der angegebenen Priorit�t und dem angegebenen Argument auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Ein Objekt, das unmittelbar nach dem Aufruf von <see cref="Overload:System.Windows.Threading.Dispatcher.BeginInvoke" /> zur�ckgegeben wird und f�r die Interaktion mit dem Delegaten verwendet werden kann, w�hrend im Delegaten die Ausf�hrung einer Aufgabe in der Warteschlange steht.</returns>
        /// <param name="priority">Die Priorit�t, relativ zu den anderen anstehenden Operationen in der <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange, mit der die angegebene Methode aufgerufen wird.</param>
        /// <param name="method">Ein Delegat zu einer Methode, die ein Argument erwartet und in die <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange gestellt wird.</param>
        /// <param name="arg">Das Objekt, das als Argument an die angegebene Methode �bergeben wird.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="method" /> ist null.</exception>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// <paramref name="priority" /> ist kein g�ltiger <see cref="T:System.Windows.Threading.DispatcherPriority" />.</exception>
        public DispatcherOperation BeginInvoke(DispatcherPriority priority, Delegate method, object arg)
        {
            return m_orgDispatcher.BeginInvoke(priority, method, arg);
        }

        /// <summary>F�hrt den angegebenen Delegaten asynchron mit der angegebenen Priorit�t und dem angegebenen Argumentarray auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Ein Objekt, das unmittelbar nach dem Aufruf von <see cref="Overload:System.Windows.Threading.Dispatcher.BeginInvoke" /> zur�ckgegeben wird und f�r die Interaktion mit dem Delegaten verwendet werden kann, w�hrend im Delegaten die Ausf�hrung einer Aufgabe in der <see cref="T:System.Windows.Threading.Dispatcher" />-Warteschlange steht.</returns>
        /// <param name="priority">Die Priorit�t, relativ zu den anderen anstehenden Operationen in der <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange, mit der die angegebene Methode aufgerufen wird.</param>
        /// <param name="method">Ein Delegat zu einer Methode, die mehrere Argumente erwartet und in die <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange gestellt wird.</param>
        /// <param name="arg">Das Objekt, das als Argument an die angegebene Methode �bergeben wird.</param>
        /// <param name="args">Ein Array von Objekten, die als Argumente an die angegebene Methode �bergeben werden sollen.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="method" /> ist null.</exception>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// <see cref="T:System.Windows.Threading.DispatcherPriority" /> ist keine g�ltige Priorit�t.</exception>
        public DispatcherOperation BeginInvoke(DispatcherPriority priority, Delegate method, object arg, params object[] args)
        {
            return m_orgDispatcher.BeginInvoke(priority, method, arg, args);
        }

        /// <summary>F�hrt den angegebenen Delegaten asynchron mit den angegebenen Argumenten f�r den Thread aus, f�r den der <see cref="T:System.Windows.Threading.Dispatcher" /> erstellt wurde.</summary>
        /// <returns>Ein Objekt, das unmittelbar nach dem Aufruf von <see cref="Overload:System.Windows.Threading.Dispatcher.BeginInvoke" /> zur�ckgegeben wird und f�r die Interaktion mit dem Delegaten verwendet werden kann, w�hrend im Delegaten die Ausf�hrung einer Aufgabe in der Warteschlange steht.</returns>
        /// <param name="method">Der Delegat f�r eine Methode, die in <paramref name="args" /> angegebene Parameter akzeptiert und in die <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange gestellt wird.</param>
        /// <param name="args">Ein Array von Objekten, die als Argumente an die angegebene Methode �bergeben werden sollen. Kann null sein.</param>
        public DispatcherOperation BeginInvoke(Delegate method, params object[] args)
        {
            return m_orgDispatcher.BeginInvoke(method, args);
        }

        /// <summary>F�hrt den angegebenen Delegaten asynchron mit den angegebenen Argumenten und der angegebenen Priorit�t f�r den Thread aus, f�r den der <see cref="T:System.Windows.Threading.Dispatcher" /> erstellt wurde.</summary>
        /// <returns>Ein Objekt, das unmittelbar nach dem Aufruf von <see cref="Overload:System.Windows.Threading.Dispatcher.BeginInvoke" /> zur�ckgegeben wird und f�r die Interaktion mit dem Delegaten verwendet werden kann, w�hrend im Delegaten die Ausf�hrung einer Aufgabe in der Warteschlange steht.</returns>
        /// <param name="method">Der Delegat f�r eine Methode, die in <paramref name="args" /> angegebene Parameter akzeptiert und in die <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange gestellt wird.</param>
        /// <param name="priority">Die Priorit�t, relativ zu den anderen anstehenden Operationen in der <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange, mit der die angegebene Methode aufgerufen wird.</param>
        /// <param name="args">Ein Array von Objekten, die als Argumente an die angegebene Methode �bergeben werden sollen. Kann null sein.</param>
        public DispatcherOperation BeginInvoke(Delegate method, DispatcherPriority priority, params object[] args)
        {
            return m_orgDispatcher.BeginInvoke(method, priority, args);
        }

        /// <summary>F�hrt die angegebene <see cref="T:System.Action" /> synchron auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <param name="callback">Ein Delegat, der �ber den Verteiler aufgerufen werden soll.</param>
        public void Invoke(Action callback)
        {
            m_orgDispatcher.Invoke(callback);
        }

        /// <summary>F�hrt die angegebene <see cref="T:System.Action" /> synchron mit der angegebenen Priorit�t auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <param name="callback">Ein Delegat, der �ber den Verteiler aufgerufen werden soll.</param>
        /// <param name="priority">Die Priorit�t, die bestimmt, in welcher Reihenfolge der angegebene R�ckruf relativ zu den anderen ausstehenden Vorg�ngen in <see cref="T:System.Windows.Threading.Dispatcher" /> aufgerufen wird.</param>
        public void Invoke(Action callback, DispatcherPriority priority)
        {
            m_orgDispatcher.Invoke(callback, priority);
        }

        /// <summary>F�hrt die angegebene <see cref="T:System.Action" /> synchron mit der angegebenen Priorit�t auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <param name="callback">Ein Delegat, der �ber den Verteiler aufgerufen werden soll.</param>
        /// <param name="priority">Die Priorit�t, die bestimmt, in welcher Reihenfolge der angegebene R�ckruf relativ zu den anderen ausstehenden Vorg�ngen in <see cref="T:System.Windows.Threading.Dispatcher" /> aufgerufen wird.</param>
        /// <param name="cancellationToken">Ein Objekt, das angibt, ob die Aktion abgebrochen werden kann.</param>
        public void Invoke(Action callback, DispatcherPriority priority, CancellationToken cancellationToken)
        {
            m_orgDispatcher.Invoke(callback, priority, cancellationToken);
        }

        /// <summary>F�hrt die angegebene <see cref="T:System.Action" /> synchron mit der angegebenen Priorit�t auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <param name="callback">Ein Delegat, der �ber den Verteiler aufgerufen werden soll.</param>
        /// <param name="priority">Die Priorit�t, die bestimmt, in welcher Reihenfolge der angegebene R�ckruf relativ zu den anderen ausstehenden Vorg�ngen in <see cref="T:System.Windows.Threading.Dispatcher" /> aufgerufen wird.</param>
        /// <param name="cancellationToken">Ein Objekt, das angibt, ob die Aktion abgebrochen werden kann.</param>
        /// <param name="timeout">Die minimale Zeitspanne, die auf den Start des Vorgangs gewartet wird.</param>
        public void Invoke(Action callback, DispatcherPriority priority, CancellationToken cancellationToken, TimeSpan timeout)
        {
            m_orgDispatcher.Invoke(callback, priority, cancellationToken, timeout);
        }

        /// <summary>F�hrt die angegebene <see cref="T:System.Func`1" /> synchron auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <param name="callback">Ein Delegat, der �ber den Verteiler aufgerufen werden soll.</param>
        /// <typeparam name="TResult">Der R�ckgabewerts des angegebenen Delegaten.</typeparam>
        public TResult Invoke<TResult>(Func<TResult> callback)
        {
            return m_orgDispatcher.Invoke(callback);
        }

        /// <summary>F�hrt die angegebene <see cref="T:System.Func`1" /> synchron mit der angegebenen Priorit�t auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <param name="callback">Ein Delegat, der �ber den Verteiler aufgerufen werden soll.</param>
        /// <param name="priority">Die Priorit�t, die bestimmt, in welcher Reihenfolge der angegebene R�ckruf relativ zu den anderen ausstehenden Vorg�ngen in <see cref="T:System.Windows.Threading.Dispatcher" /> aufgerufen wird.</param>
        /// <typeparam name="TResult">Der R�ckgabewerts des angegebenen Delegaten.</typeparam>
        public TResult Invoke<TResult>(Func<TResult> callback, DispatcherPriority priority)
        {
            return m_orgDispatcher.Invoke(callback, priority);
        }

        /// <summary>F�hrt die angegebene <see cref="T:System.Func`1" /> synchron mit der angegebenen Priorit�t auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <param name="callback">Ein Delegat, der �ber den Verteiler aufgerufen werden soll.</param>
        /// <param name="priority">Die Priorit�t, die bestimmt, in welcher Reihenfolge der angegebene R�ckruf relativ zu den anderen ausstehenden Vorg�ngen in <see cref="T:System.Windows.Threading.Dispatcher" /> aufgerufen wird.</param>
        /// <param name="cancellationToken">Ein Objekt, das angibt, ob der Vorgang abgebrochen werden kann.</param>
        /// <typeparam name="TResult">Der R�ckgabewerts des angegebenen Delegaten.</typeparam>
        public TResult Invoke<TResult>(Func<TResult> callback, DispatcherPriority priority, CancellationToken cancellationToken)
        {
            return m_orgDispatcher.Invoke(callback, priority, cancellationToken);
        }

        /// <summary>F�hrt die angegebene <see cref="T:System.Func`1" /> synchron mit der angegebenen Priorit�t auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <param name="callback">Ein Delegat, der �ber den Verteiler aufgerufen werden soll.</param>
        /// <param name="priority">Die Priorit�t, die bestimmt, in welcher Reihenfolge der angegebene R�ckruf relativ zu den anderen ausstehenden Vorg�ngen in <see cref="T:System.Windows.Threading.Dispatcher" /> aufgerufen wird.</param>
        /// <param name="cancellationToken">Ein Objekt, das angibt, ob der Vorgang abgebrochen werden kann.</param>
        /// <param name="timeout">Die minimale Zeitspanne, die auf den Start des Vorgangs gewartet wird.</param>
        /// <typeparam name="TResult">Der R�ckgabewerts des angegebenen Delegaten.</typeparam>
        public TResult Invoke<TResult>(Func<TResult> callback, DispatcherPriority priority, CancellationToken cancellationToken, TimeSpan timeout)
        {
            return m_orgDispatcher.Invoke(callback, priority, cancellationToken, timeout);
        }

        /// <summary>F�hrt die angegebene <see cref="T:System.Action" /> asynchron auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Ein Objekt, das unmittelbar nach dem Aufruf von <see cref="M:System.Windows.Threading.Dispatcher.InvokeAsync(System.Action)" /> zur�ckgegeben wird und f�r die Interaktion mit dem Delegaten verwendet werden kann, w�hrend im Delegaten die Ausf�hrung einer Aufgabe in der Warteschlange steht.</returns>
        /// <param name="callback">Ein Delegat, der �ber den Verteiler aufgerufen werden soll.</param>
        public DispatcherOperation InvokeAsync(Action callback)
        {
            return m_orgDispatcher.InvokeAsync(callback);
        }

        /// <summary>F�hrt die angegebene <see cref="T:System.Action" /> asynchron mit der angegebenen Priorit�t auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Ein Objekt, das unmittelbar nach dem Aufruf von <see cref="M:System.Windows.Threading.Dispatcher.InvokeAsync(System.Action,System.Windows.Threading.DispatcherPriority)" /> zur�ckgegeben wird und f�r die Interaktion mit dem Delegaten verwendet werden kann, w�hrend im Delegaten die Ausf�hrung einer Aufgabe in der Warteschlange steht.</returns>
        /// <param name="callback">Ein Delegat, der �ber den Verteiler aufgerufen werden soll.</param>
        /// <param name="priority">Die Priorit�t, die bestimmt, in welcher Reihenfolge der angegebene R�ckruf relativ zu den anderen ausstehenden Vorg�ngen in <see cref="T:System.Windows.Threading.Dispatcher" /> aufgerufen wird.</param>
        public DispatcherOperation InvokeAsync(Action callback, DispatcherPriority priority)
        {
            return m_orgDispatcher.InvokeAsync(callback, priority);
        }

        /// <summary>F�hrt die angegebene <see cref="T:System.Action" /> asynchron mit der angegebenen Priorit�t auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Ein Objekt, das unmittelbar nach dem Aufruf von <see cref="M:System.Windows.Threading.Dispatcher.InvokeAsync(System.Action,System.Windows.Threading.DispatcherPriority,System.Threading.CancellationToken)" /> zur�ckgegeben wird und f�r die Interaktion mit dem Delegaten verwendet werden kann, w�hrend im Delegaten die Ausf�hrung einer Aufgabe in der Warteschlange steht.</returns>
        /// <param name="callback">Ein Delegat, der �ber den Verteiler aufgerufen werden soll.</param>
        /// <param name="priority">Die Priorit�t, die bestimmt, in welcher Reihenfolge der angegebene R�ckruf relativ zu den anderen ausstehenden Vorg�ngen in <see cref="T:System.Windows.Threading.Dispatcher" /> aufgerufen wird.</param>
        /// <param name="cancellationToken">Ein Objekt, das angibt, ob die Aktion abgebrochen werden kann.</param>
        public DispatcherOperation InvokeAsync(Action callback, DispatcherPriority priority, CancellationToken cancellationToken)
        {
            return m_orgDispatcher.InvokeAsync(callback, priority, cancellationToken);
        }

        /// <summary>F�hrt die angegebene <see cref="T:System.Func`1" /> asynchron auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Ein Objekt, das unmittelbar nach dem Aufruf von <see cref="M:System.Windows.Threading.Dispatcher.InvokeAsync``1(System.Func{``0})" /> zur�ckgegeben wird und f�r die Interaktion mit dem Delegaten verwendet werden kann, w�hrend im Delegaten die Ausf�hrung einer Aufgabe in der Warteschlange steht.</returns>
        /// <param name="callback">Ein Delegat, der �ber den Verteiler aufgerufen werden soll.</param>
        /// <typeparam name="TResult">Der R�ckgabewerts des angegebenen Delegaten.</typeparam>
        public DispatcherOperation<TResult> InvokeAsync<TResult>(Func<TResult> callback)
        {
            return m_orgDispatcher.InvokeAsync(callback);
        }

        /// <summary>F�hrt die angegebene <see cref="T:System.Func`1" /> asynchron mit der angegebenen Priorit�t auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Ein Objekt, das unmittelbar nach dem Aufruf von <see cref="M:System.Windows.Threading.Dispatcher.InvokeAsync``1(System.Func{``0},System.Windows.Threading.DispatcherPriority)" /> zur�ckgegeben wird und f�r die Interaktion mit dem Delegaten verwendet werden kann, w�hrend im Delegaten die Ausf�hrung einer Aufgabe in der Warteschlange steht.</returns>
        /// <param name="callback">Ein Delegat, der �ber den Verteiler aufgerufen werden soll.</param>
        /// <param name="priority">Die Priorit�t, die bestimmt, in welcher Reihenfolge der angegebene R�ckruf relativ zu den anderen ausstehenden Vorg�ngen in <see cref="T:System.Windows.Threading.Dispatcher" /> aufgerufen wird.</param>
        /// <typeparam name="TResult">Der R�ckgabewerts des angegebenen Delegaten.</typeparam>
        public DispatcherOperation<TResult> InvokeAsync<TResult>(Func<TResult> callback, DispatcherPriority priority)
        {
            return m_orgDispatcher.InvokeAsync(callback, priority);
        }

        /// <summary>F�hrt die angegebene <see cref="T:System.Func`1" /> synchron mit der angegebenen Priorit�t auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Ein Objekt, das unmittelbar nach dem Aufruf von <see cref="M:System.Windows.Threading.Dispatcher.InvokeAsync``1(System.Func{``0},System.Windows.Threading.DispatcherPriority,System.Threading.CancellationToken)" /> zur�ckgegeben wird und f�r die Interaktion mit dem Delegaten verwendet werden kann, w�hrend im Delegaten die Ausf�hrung einer Aufgabe in der Warteschlange steht.</returns>
        /// <param name="callback">Ein Delegat, der �ber den Verteiler aufgerufen werden soll.</param>
        /// <param name="priority">Die Priorit�t, die bestimmt, in welcher Reihenfolge der angegebene R�ckruf relativ zu den anderen ausstehenden Vorg�ngen in <see cref="T:System.Windows.Threading.Dispatcher" /> aufgerufen wird.</param>
        /// <param name="cancellationToken">Ein Objekt, das angibt, ob der Vorgang abgebrochen werden kann.</param>
        /// <typeparam name="TResult">Der R�ckgabewerts des angegebenen Delegaten.</typeparam>
        public DispatcherOperation<TResult> InvokeAsync<TResult>(Func<TResult> callback, DispatcherPriority priority, CancellationToken cancellationToken)
        {
            return m_orgDispatcher.InvokeAsync(callback, priority, cancellationToken);
        }

        /// <summary>F�hrt den angegebenen Delegaten synchron mit der angegebenen Priorit�t auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Der R�ckgabewert des aufgerufenen Delegaten bzw. null, wenn der Delegat keinen Wert zur�ckgibt.</returns>
        /// <param name="priority">Die Priorit�t, relativ zu den anderen anstehenden Operationen in der <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange, mit der die angegebene Methode aufgerufen wird.</param>
        /// <param name="method">Ein Delegat zu einer Methode, die keine Argumente erwartet und in die <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange gestellt wird.</param>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="priority" /> ist gleich <see cref="F:System.Windows.Threading.DispatcherPriority.Inactive" />.</exception>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// <paramref name="priority" /> ist keine g�ltige Priorit�t.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="method" /> ist null.</exception>
        public object Invoke(DispatcherPriority priority, Delegate method)
        {
            return m_orgDispatcher.Invoke(priority, method);
        }

        /// <summary>F�hrt den angegebenen Delegaten mit der angegebenen Priorit�t und dem angegebenen Argument synchron auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Der R�ckgabewert des aufgerufenen Delegaten bzw. null, wenn der Delegat keinen Wert zur�ckgibt.</returns>
        /// <param name="priority">Die Priorit�t, relativ zu den anderen anstehenden Operationen in der <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange, mit der die angegebene Methode aufgerufen wird.</param>
        /// <param name="method">Ein Delegat zu einer Methode, die ein Argument erwartet und in die <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange gestellt wird.</param>
        /// <param name="arg">Ein Objekt, das als Argument an die angegebene Methode �bergeben werden soll.</param>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="priority" /> ist gleich <see cref="F:System.Windows.Threading.DispatcherPriority.Inactive" />.</exception>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// <paramref name="priority" /> ist keine g�ltige Priorit�t.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="method" /> ist null.</exception>
        public object Invoke(DispatcherPriority priority, Delegate method, object arg)
        {
            return m_orgDispatcher.Invoke(priority, method, arg);
        }

        /// <summary>F�hrt den angegebenen Delegaten mit der angegebenen Priorit�t und den angegebenen Argumenten synchron auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Der R�ckgabewert des aufgerufenen Delegaten bzw. null, wenn der Delegat keinen Wert zur�ckgibt.</returns>
        /// <param name="priority">Die Priorit�t, relativ zu den anderen anstehenden Operationen in der <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange, mit der die angegebene Methode aufgerufen wird.</param>
        /// <param name="method">Ein Delegat zu einer Methode, die mehrere Argumente erwartet und in die <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange gestellt wird.</param>
        /// <param name="arg">Ein Objekt, das als Argument an die angegebene Methode �bergeben werden soll.</param>
        /// <param name="args">Ein Array von Objekten, die als Argumente an die angegebene Methode �bergeben werden sollen.</param>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="priority" /> ist gleich <see cref="F:System.Windows.Threading.DispatcherPriority.Inactive" />.</exception>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// <paramref name="priority" /> ist keine g�ltige Priorit�t.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="method" /> ist null.</exception>
        public object Invoke(DispatcherPriority priority, Delegate method, object arg, params object[] args)
        {
            return m_orgDispatcher.Invoke(priority, method, arg, args);
        }

        /// <summary>F�hrt den angegebenen Delegaten synchron mit der angegebenen Priorit�t und dem angegebenen Timeoutwert auf dem Thread aus, in dem der <see cref="T:System.Windows.Threading.Dispatcher" /> erstellt wurde.</summary>
        /// <returns>Der R�ckgabewert des aufgerufenen Delegaten bzw. null, wenn der Delegat keinen Wert zur�ckgibt.</returns>
        /// <param name="priority">Die Priorit�t, relativ zu den anderen anstehenden Operationen in der <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange, mit der die angegebene Methode aufgerufen wird.</param>
        /// <param name="timeout">Die maximale Zeit, die auf den Abschluss der Operation gewartet wird.</param>
        /// <param name="method">Der Delegat zu einer Methode, die keine Argumente erwartet und in die <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange gestellt wird.</param>
        public object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method)
        {
            return m_orgDispatcher.Invoke(priority, timeout, method);
        }

        /// <summary>F�hrt den angegebenen Delegaten mit der angegebenen Priorit�t und dem angegebenen Argument synchron auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Der R�ckgabewert des aufgerufenen Delegaten bzw. null, wenn der Delegat keinen Wert zur�ckgibt.</returns>
        /// <param name="priority">Die Priorit�t, relativ zu den anderen anstehenden Operationen in der <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange, mit der die angegebene Methode aufgerufen wird.</param>
        /// <param name="timeout">Die maximale Zeit, die auf den Abschluss der Operation gewartet wird.</param>
        /// <param name="method">Ein Delegat zu einer Methode, die mehrere Argumente erwartet und in die <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange gestellt wird.</param>
        /// <param name="arg">Ein Objekt, das als Argument an die angegebene Methode �bergeben werden soll. Dies kann null sein, wenn keine Argumente ben�tigt werden.</param>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="priority" /> ist gleich <see cref="F:System.Windows.Threading.DispatcherPriority.Inactive" />.</exception>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// <paramref name="priority" /> ist keine g�ltige Priorit�t.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="method" /> ist null.</exception>
        public object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method, object arg)
        {
            return m_orgDispatcher.Invoke(priority, timeout, method, arg);
        }

        /// <summary>F�hrt den angegebenen Delegaten mit der angegebenen Priorit�t und den angegebenen Argumenten synchron auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Der R�ckgabewert des aufgerufenen Delegaten bzw. null, wenn der Delegat keinen Wert zur�ckgibt.</returns>
        /// <param name="priority">Die Priorit�t, relativ zu den anderen anstehenden Operationen in der <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange, mit der die angegebene Methode aufgerufen wird.</param>
        /// <param name="timeout">Die maximale Zeit, die auf den Abschluss der Operation gewartet wird.</param>
        /// <param name="method">Ein Delegat zu einer Methode, die mehrere Argumente erwartet und in die <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange gestellt wird.</param>
        /// <param name="arg">Ein Objekt, das als Argument an die angegebene Methode �bergeben wird.</param>
        /// <param name="args">Ein Array von Objekten, die als Argumente an die angegebene Methode �bergeben werden sollen.</param>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="priority" /> ist gleich <see cref="F:System.Windows.Threading.DispatcherPriority.Inactive" />.</exception>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        /// <paramref name="priority" /> ist kein g�ltiger <see cref="T:System.Windows.Threading.DispatcherPriority" />.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="method" /> ist null.</exception>
        public object Invoke(DispatcherPriority priority, TimeSpan timeout, Delegate method, object arg, params object[] args)
        {
            return m_orgDispatcher.Invoke(priority, timeout, method, arg, args);
        }

        /// <summary>F�hrt den angegebenen Delegaten synchron mit den angegebenen Argumenten f�r den Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Der R�ckgabewert des aufgerufenen Delegaten bzw. null, wenn der Delegat keinen Wert zur�ckgibt.</returns>
        /// <param name="method">Ein Delegat f�r eine Methode, die in <paramref name="args" /> angegebene Parameter akzeptiert und in die <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange gestellt wird.</param>
        /// <param name="args">Ein Array von Objekten, die als Argumente an die angegebene Methode �bergeben werden sollen. Kann null sein.</param>
        public object Invoke(Delegate method, params object[] args)
        {
            return m_orgDispatcher.Invoke(method, args);
        }

        /// <summary>F�hrt den angegebenen Delegaten mit der angegebenen Priorit�t und den angegebenen Argumenten synchron auf dem Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Der R�ckgabewert des aufgerufenen Delegaten bzw. null, wenn der Delegat keinen Wert zur�ckgibt.</returns>
        /// <param name="method">Ein Delegat f�r eine Methode, die in <paramref name="args" /> angegebene Parameter akzeptiert und in die <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange gestellt wird.</param>
        /// <param name="priority">Die Priorit�t, relativ zu den anderen anstehenden Operationen in der <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange, mit der die angegebene Methode aufgerufen wird.</param>
        /// <param name="args">Ein Array von Objekten, die als Argumente an die angegebene Methode �bergeben werden sollen. Kann null sein.</param>
        public object Invoke(Delegate method, DispatcherPriority priority, params object[] args)
        {
            return m_orgDispatcher.Invoke(method, priority, args);
        }

        /// <summary>F�hrt den angegebenen Delegaten in der angegebenen Zeitspanne mit der angegebenen Priorit�t und den angegebenen Argumenten synchron f�r den Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Der R�ckgabewert des aufgerufenen Delegaten bzw. null, wenn der Delegat keinen Wert zur�ckgibt.</returns>
        /// <param name="method">Ein Delegat f�r eine Methode, die in <paramref name="args" /> angegebene Parameter akzeptiert und in die <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange gestellt wird.</param>
        /// <param name="timeout">Die maximale Zeitspanne, die auf den Abschluss der Operation gewartet wird.</param>
        /// <param name="args">Ein Array von Objekten, die als Argumente an die angegebene Methode �bergeben werden sollen. Kann null sein.</param>
        public object Invoke(Delegate method, TimeSpan timeout, params object[] args)
        {
            return m_orgDispatcher.Invoke(method, timeout, args);
        }

        /// <summary>F�hrt den angegebenen Delegaten in der angegebenen Zeitspanne mit der angegebenen Priorit�t und den angegebenen Argumenten synchron f�r den Thread aus, dem der <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Der R�ckgabewert des aufgerufenen Delegaten bzw. null, wenn der Delegat keinen Wert zur�ckgibt.</returns>
        /// <param name="method">Ein Delegat f�r eine Methode, die in <paramref name="args" /> angegebene Parameter akzeptiert und in die <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange gestellt wird.</param>
        /// <param name="timeout">Die maximale Zeitspanne, die auf den Abschluss der Operation gewartet wird.</param>
        /// <param name="priority">Die Priorit�t, relativ zu den anderen anstehenden Operationen in der <see cref="T:System.Windows.Threading.Dispatcher" />-Ereigniswarteschlange, mit der die angegebene Methode aufgerufen wird.</param>
        /// <param name="args">Ein Array von Objekten, die als Argumente an die angegebene Methode �bergeben werden sollen. Kann null sein.</param>
        public object Invoke(Delegate method, TimeSpan timeout, DispatcherPriority priority, params object[] args)
        {
            return m_orgDispatcher.Invoke(method, timeout, priority, args);
        }

        /// <summary>Deaktiviert Verarbeitung der <see cref="T:System.Windows.Threading.Dispatcher" />-Warteschlange.</summary>
        /// <returns>Eine Struktur, mit der die Dispatcherverarbeitung wieder aktiviert wird.</returns>
        public DispatcherProcessingDisabled DisableProcessing()
        {
            return m_orgDispatcher.DisableProcessing();
        }

        /// <summary>Ruft den Thread ab, dem dieser <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet ist.</summary>
        /// <returns>Der Thread.</returns>
        public Thread Thread
        {
            get { return m_orgDispatcher.Thread; }
        }

        /// <summary>Bestimmt, ob der <see cref="T:System.Windows.Threading.Dispatcher" /> gerade beendet wird.</summary>
        /// <returns>true, wenn der <see cref="T:System.Windows.Threading.Dispatcher" /> gerade beendet wird, andernfalls false.</returns>
        public bool HasShutdownStarted
        {
            get { return m_orgDispatcher.HasShutdownStarted; }
        }

        /// <summary>Bestimmt, ob der <see cref="T:System.Windows.Threading.Dispatcher" /> die Beendigung abgeschlossen hat.</summary>
        /// <returns>true, wenn der Verteiler die Beendigung abgeschlossen hat, andernfalls false.</returns>
        public bool HasShutdownFinished
        {
            get { return m_orgDispatcher.HasShutdownFinished; }
        }

        /// <summary>Ruft die Auflistung von Hooks ab, die zus�tzliche Ereignisinformationen zum <see cref="T:System.Windows.Threading.Dispatcher" /> bereitstellen.</summary>
        /// <returns>Die Hooks, die diesem <see cref="T:System.Windows.Threading.Dispatcher" /> zugeordnet sind.</returns>
        public DispatcherHooks Hooks
        {
            get { return m_orgDispatcher.Hooks; }
        }

        public event EventHandler ShutdownStarted
        {
            add { m_orgDispatcher.ShutdownStarted += value; }
            remove { m_orgDispatcher.ShutdownStarted -= value; }
        }

        public event EventHandler ShutdownFinished
        {
            add { m_orgDispatcher.ShutdownFinished += value; }
            remove { m_orgDispatcher.ShutdownFinished -= value; }
        }

        public event DispatcherUnhandledExceptionFilterEventHandler UnhandledExceptionFilter
        {
            add { m_orgDispatcher.UnhandledExceptionFilter += value; }
            remove { m_orgDispatcher.UnhandledExceptionFilter -= value; }
        }

        public event DispatcherUnhandledExceptionEventHandler UnhandledException
        {
            add { m_orgDispatcher.UnhandledException += value; }
            remove { m_orgDispatcher.UnhandledException -= value; }
        }

        private Dispatcher m_orgDispatcher;
        public DispatcherWrapper(Dispatcher orgDispatcher)
        {
            m_orgDispatcher = orgDispatcher;
        }
    }
}