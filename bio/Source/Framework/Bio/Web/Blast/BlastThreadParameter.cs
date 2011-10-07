﻿namespace Bio.Web.Blast
{
    /// <summary>
    /// This class has the list of properties that needs to be passed on to
    /// the BackGroundWorker thread to execute the search request.
    /// </summary>
    public class BlastThreadParameter
    {
        /// <summary>
        /// Unique Search ID generated by Bio
        /// </summary>
        private string _requestIdentifier;

        /// <summary>
        /// Sequence object
        /// </summary>
        private ISequence _sequence;

        /// <summary>
        /// Blast parameters object
        /// </summary>
        private BlastParameters _parameter;

        /// <summary>
        /// Initializes a new instance of the ThreadParameter class. 
        /// </summary>
        /// <param name="requestIdentifier">Job identifier</param>
        /// <param name="sequence">Sequence Object</param>
        /// <param name="parameter">Blast Parameters</param>
        public BlastThreadParameter(
                string requestIdentifier,
                ISequence sequence,
                BlastParameters parameter)
        {
            _requestIdentifier = requestIdentifier;
            _sequence = sequence;
            _parameter = parameter;
        }

        /// <summary>
        /// Unique Search ID generated by Bio
        /// </summary>
        public string RequestIdentifier
        {
            get { return _requestIdentifier; }
        }

        /// <summary>
        /// Gets the sequence object
        /// </summary>
        public ISequence Sequence
        {
            get { return _sequence; }
        }

        /// <summary>
        /// Gets the Blast parameters
        /// </summary>
        public BlastParameters Parameters
        {
            get { return _parameter; }
        }
    }
}
